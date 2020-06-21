﻿using BCA.Common;

namespace BCA.Network.Packets.Standard.FromServer
{
    public class StandardServerOpenPrestigeShop : Packet
    {
        public int PP { get; set; }
        public int Progress { get; set; }
        public CustomSpecialPack SpecialPack { get; set; }
    }
}
