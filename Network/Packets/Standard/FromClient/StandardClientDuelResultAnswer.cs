﻿using BCA.Common;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelResultAnswer : Packet
    {
        public RoomConfig Config { get; set; }
        public int Opponent { get; set; }
        public bool Result { get; set; }
        public int RoomID { get; set; }
    }
}
