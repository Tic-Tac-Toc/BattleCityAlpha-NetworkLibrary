﻿using BCA.Common;
using BCA.Network.Packets.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerChatMessage : Packet
    {
        public ChatMessageType Type { get; set; }
        public PlayerInfo Player { get; set; }
        public string Message { get; set; }
    }
}
