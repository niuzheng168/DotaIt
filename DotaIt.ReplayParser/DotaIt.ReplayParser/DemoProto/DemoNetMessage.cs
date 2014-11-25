namespace DotaIt.ReplayParser.DemoProto
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net messages.
    /// </summary>
    public class DemoNetMessage<T> : MessageBase
    {
        private NET_Messages_Kind _kind;

        private T _messageInstance;

        public NET_Messages_Kind Kind
        {
            get
            {
                return _kind;
            }
        }

        public T MessageInstance
        {
            get
            {
                return _messageInstance;
            }
        }

        public DemoNetMessage(int kindValue, byte[] message)
            : base(kindValue, message)
        {
            this._kind = (NET_Messages_Kind)kindValue;
        }

        public override void BuildMessageInstance()
        {
            _messageInstance = Helper.DeserilizedFromBytes<T>(Message);
        }

        public static DemoNetMessage<T> Create(int kind, byte[] message)
        {
            DemoNetMessage<T> netMessage = new DemoNetMessage<T>(kind, message);
            netMessage.BuildMessageInstance();
            return netMessage;
        }
    }
}