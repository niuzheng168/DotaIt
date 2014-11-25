namespace DotaIt.ReplayParser.DemoProto
{
    using System.Collections.Generic;
    using System.IO;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The demo message class info.
    /// </summary>
    public class DemoMessageClassInfo : DemoMessageBase, IPacked
    {
        public DemoMessageClassInfo(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_ClassInfo;
        }

        private CDemoClassInfo _classInfo;
        public new CDemoClassInfo MessageInstance
        {
            get
            {
                return _classInfo;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _classInfo = Helper.DeserilizedFromBytes<CDemoClassInfo>(Message);
        }

        public void Unpack()
        {
            using (MemoryStream ms = new MemoryStream(this.MessageInstance.classes))
            {
                while (ms.Position < ms.Length)
                {
                    int kindValue = ProtoReader.DirectReadVarintInt32(ms);
                    int size = ProtoReader.DirectReadVarintInt32(ms);
                    byte[] buffer = new byte[size];
                    ms.Read(buffer, 0, size);
                    MessageBase m = PacketMessage.CreateMessage(kindValue, buffer);
                    if (m != null)
                    {
                        m.BuildMessageInstance();
                        _unpackedMessageList.Add(m);
                    }
                }
            }
        }

        private List<MessageBase> _unpackedMessageList = new List<MessageBase>();

        public List<MessageBase> UnpackedMessageList
        {
            get
            {
                return _unpackedMessageList;
            }
        }
    }
}