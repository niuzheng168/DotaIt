namespace DotaIt.ReplayParser.DemoProto
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The demo server massage.
    /// </summary>
    public class DemoSVCMassage<T> : PacketMessage<T>
    {
        protected SVC_Messages_Kind _kind;

        public SVC_Messages_Kind Kind
        {
            get
            {
                return _kind;
            }
        }

        public DemoSVCMassage(int kindValue, byte[] message)
            : base(kindValue, message)
        {
            this._kind = (SVC_Messages_Kind)kindValue;
        }

        public new static DemoSVCMassage<T> Create(int kind, byte[] message)
        {
            DemoSVCMassage<T> svcMessages = new DemoSVCMassage<T>(kind, message);
            return svcMessages;
        }
    }
}