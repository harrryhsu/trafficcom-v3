﻿using TrafficCom.V3.Messages;

namespace TrafficCom.V3.Request
{
    public class V3RequestX0FX42 : V3Request
    {
        public override byte Cmd1 => 0x0F;

        public override byte Cmd2 => 0x42;

        public V3RequestX0FX42()
        {
        }

        public V3RequestX0FX42(DataMessage msg) : base(msg)
        {
        }
    }
}