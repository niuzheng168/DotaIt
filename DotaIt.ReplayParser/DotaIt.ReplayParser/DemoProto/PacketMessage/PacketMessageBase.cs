namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    public class PacketMessageBase : MessageBase
    {
        public PacketMessageBase(int kindValue, byte[] message, int tick)
            : base(kindValue, message)
        {
            this._tick = tick;
        }

        /// <summary>
        /// The tick.
        /// </summary>
        protected int _tick = -1;

        public int Tick
        {
            get
            {
                return this._tick;
            }
        }

        private byte[] _messageInstance;
        public byte[] MessageInstance
        {
            get
            {
                return this._messageInstance;
            }
        }
    }
}