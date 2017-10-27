﻿using BCA.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Network.Packets.Standard.FromClient
{
    public class StandardClientDuelRequest : Packet
    {
        public int TargetId { get; set; }
        public DuelType Type { get; set; }
    }
}