namespace DotaIt.ReplayParser.DemoProto.DemoMessages
{
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The demo message sync tick.
    /// </summary>
    public class DemoMessageSyncTick : DemoMessageBase, IAnalysable
    {
        public DemoMessageSyncTick(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_SyncTick;
        }

        private CDemoSyncTick _syncTick = null;

        public new CDemoSyncTick MessageInstance
        {
            get
            {
                return _syncTick;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._syncTick = Helper.DeserilizedFromBytes<CDemoSyncTick>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            foreach (CSVCMsg_SendTable sendTable in demo.DtClasses.ById.Values)
            {
                if (!sendTable.needs_decoder)
                {
                    continue;
                }

                SendTableFlattener flattener = new SendTableFlattener(demo.DtClasses, sendTable);
                List<ReceiveProp> rps = flattener.Flatten();
                sendTable.SetReceiveProps(rps);
            }
        }
    }
}