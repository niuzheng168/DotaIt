﻿namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcSendTable : PacketMessageBase
    {
        public SvcSendTable(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_SendTable _setConVar;

        public new CSVCMsg_SendTable MessageInstance
        {
            get
            {
                return _setConVar;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _setConVar = Helper.DeserilizedFromBytes<CSVCMsg_SendTable>(Message);
        }
    }
}