namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class NetSetConVar : PacketMessageBase
    {
        public NetSetConVar(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CNETMsg_SetConVar _setConVar;

        public new CNETMsg_SetConVar MessageInstance
        {
            get
            {
                return _setConVar;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _setConVar = Helper.DeserilizedFromBytes<CNETMsg_SetConVar>(Message);
        }
    }
}