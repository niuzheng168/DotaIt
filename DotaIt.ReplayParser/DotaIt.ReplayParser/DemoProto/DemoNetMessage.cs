namespace DotaIt.ReplayParser.DemoProto
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net messages.
    /// </summary>
    public class DemoNetMessage<T> : PacketMessage<T>
    {
        private NET_Messages_Kind _kind;


        public NET_Messages_Kind Kind
        {
            get
            {
                return _kind;
            }
        }

        public DemoNetMessage(int kindValue, byte[] message)
            : base(kindValue, message)
        {
            this._kind = (NET_Messages_Kind)kindValue;
        }

        public new static DemoNetMessage<T> Create(int kind, byte[] message)
        {
            DemoNetMessage<T> svcMessages = new DemoNetMessage<T>(kind, message);
            return svcMessages;
        }
    }
}