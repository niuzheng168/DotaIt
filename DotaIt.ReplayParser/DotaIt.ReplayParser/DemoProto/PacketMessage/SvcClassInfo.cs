namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcClassInfo : PacketMessageBase, IAnalysable
    {
        public SvcClassInfo(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_ClassInfo _classInfo;

        public new CSVCMsg_ClassInfo MessageInstance
        {
            get
            {
                return this._classInfo;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._classInfo = Helper.DeserilizedFromBytes<CSVCMsg_ClassInfo>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();
            foreach (CSVCMsg_ClassInfo.class_t ct in this._classInfo.classes)
            {
                
            }
        }
    }
}