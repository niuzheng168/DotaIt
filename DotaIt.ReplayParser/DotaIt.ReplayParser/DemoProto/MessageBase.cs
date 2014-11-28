namespace DotaIt.ReplayParser.DemoProto
{
    /// <summary>
    /// The message base.
    /// </summary>
    public class MessageBase
    {
        public int KindValue { get; set; }
        public int Size { get; set; }
        public byte[] Message { get; set; }

        public MessageBase()
        {
            KindValue = int.MinValue;
            Size = -1;
            Message = null;
        }

        public MessageBase(int kindValue, byte[] message)
        {
            KindValue = kindValue;
            Message = message;
            if (message == null)
            {
                Size = 0;
            }
            else
            {
                Size = message.Length;
            }
        }

        public virtual void BuildMessageInstance()
        {
        }
    }
}