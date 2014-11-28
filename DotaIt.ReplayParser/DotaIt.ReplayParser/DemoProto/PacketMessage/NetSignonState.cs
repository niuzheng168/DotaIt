namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class NetSignonState : PacketMessageBase
    {
        public NetSignonState(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CNETMsg_SignonState _setConVar;

        public new CNETMsg_SignonState MessageInstance
        {
            get
            {
                return _setConVar;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _setConVar = Helper.DeserilizedFromBytes<CNETMsg_SignonState>(Message);
        }
    }
}