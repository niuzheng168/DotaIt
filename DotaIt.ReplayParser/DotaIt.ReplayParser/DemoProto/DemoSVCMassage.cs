namespace DotaIt.ReplayParser.DemoProto
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The demo server massage.
    /// </summary>
    public class DemoSVCMassage<T> : MessageBase
    {
        private SVC_Messages_Kind _kind;

        private T _messageInstance;

        public SVC_Messages_Kind Kind
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

        public DemoSVCMassage(int kindValue, byte[] message)
            : base(kindValue, message)
        {
            this._kind = (SVC_Messages_Kind)kindValue;
        }

        public override void BuildMessageInstance()
        {
            _messageInstance = Helper.DeserilizedFromBytes<T>(Message);
        }

        public static DemoSVCMassage<T> Create(int kind, byte[] message)
        {
            DemoSVCMassage<T> svcMessages = new DemoSVCMassage<T>(kind, message);
            svcMessages.BuildMessageInstance();
            return svcMessages;
        }

    }
}