namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcClassInfo : PacketMessageBase
    {
        public SvcClassInfo(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_ClassInfo _setConVar;

        public new CSVCMsg_ClassInfo MessageInstance
        {
            get
            {
                return _setConVar;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _setConVar = Helper.DeserilizedFromBytes<CSVCMsg_ClassInfo>(Message);
        }
    }
}