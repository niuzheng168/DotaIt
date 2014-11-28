namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcSounds : PacketMessageBase
    {
        public SvcSounds(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_Sounds _setConVar;

        public new CSVCMsg_Sounds MessageInstance
        {
            get
            {
                return _setConVar;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _setConVar = Helper.DeserilizedFromBytes<CSVCMsg_Sounds>(Message);
        }
    }
}