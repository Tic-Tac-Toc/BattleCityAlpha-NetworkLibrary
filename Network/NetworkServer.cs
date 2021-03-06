﻿using NLog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace BCA.Network
{
    public class NetworkServer
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public bool IsListening { get; private set; }

        public event Action<NetworkClient> ClientConnected;

        private TcpListener _listener;
        private bool _isClosed;

        private List<NetworkClient> _acceptedClients = new List<NetworkClient>();

        public NetworkServer(IPAddress address, int port)
        {
            _listener = new TcpListener(address, port);
        }

        public void Start()
        {
            if (!IsListening && !_isClosed)
            {
                IsListening = true;
                _listener.Start();
                BeginAcceptSocket();
            }
        }

        public void Close()
        {
            if (!_isClosed)
            {
                _isClosed = true;
                IsListening = false;
                _listener.Stop();
            }
        }

        public virtual void Update()
        {
            List<NetworkClient> clients = new List<NetworkClient>();
            lock (_acceptedClients)
            {
                clients.AddRange(_acceptedClients);
                _acceptedClients.Clear();
            }
            foreach (NetworkClient client in clients)
            {
                ClientConnected?.Invoke(client);
            }
        }

        private void BeginAcceptSocket()
        {
            try
            {
                _listener.BeginAcceptSocket(AcceptSocketCallback, null);
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.ToString());
                Close();
            }
        }

        private void AcceptSocketCallback(IAsyncResult result)
        {
            try
            {
                Socket socket = _listener.EndAcceptSocket(result);
                NetworkClient client = new NetworkClient(socket);
                lock (_acceptedClients)
                {
                    if (client.IsConnected)
                        _acceptedClients.Add(client);
                }
                BeginAcceptSocket();
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.ToString());
                Close();
            }
        }
    }
}
