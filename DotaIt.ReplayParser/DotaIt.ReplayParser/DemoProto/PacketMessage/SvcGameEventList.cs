﻿namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcGameEventList : PacketMessageBase, IAnalysable
    {
        public SvcGameEventList(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_GameEventList _setConVar;

        public new CSVCMsg_GameEventList MessageInstance
        {
            get
            {
                return _setConVar;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _setConVar = Helper.DeserilizedFromBytes<CSVCMsg_GameEventList>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();
            foreach (var desc in this.MessageInstance.descriptors)
            {
                demo.GameEventDescriptors.Add(desc);
            }
        }
    }
}