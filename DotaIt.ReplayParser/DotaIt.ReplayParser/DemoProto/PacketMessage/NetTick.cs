namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class NetTick : PacketMessageBase
    {
        public NetTick(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CNETMsg_Tick _setConVar;

        public new CNETMsg_Tick MessageInstance
        {
            get
            {
                return _setConVar;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _setConVar = Helper.DeserilizedFromBytes<CNETMsg_Tick>(Message);
        }
    }
}