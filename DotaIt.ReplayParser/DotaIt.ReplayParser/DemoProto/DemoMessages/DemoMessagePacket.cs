namespace DotaIt.ReplayParser.DemoProto.DemoMessages
{
    using System.Collections.Generic;
    using System.IO;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The demo message packet.
    /// </summary>
    public class DemoMessagePacket : DemoMessageBase, IPacked
    {
        public DemoMessagePacket(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_Packet;
        }

        public CDemoPacket _packet;

        public new CDemoPacket MessageInstance
        {
            get
            {
                return _packet;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _packet = Helper.DeserilizedFromBytes<CDemoPacket>(Message);
        }

        public void Unpack()
        {
            using (MemoryStream ms = new MemoryStream(this.MessageInstance.data))
            {
                while (ms.Position < ms.Length)
                {
                    int kindValue = ProtoReader.DirectReadVarintInt32(ms);
                    int size = ProtoReader.DirectReadVarintInt32(ms);
                    byte[] buffer = new byte[size];
                    ms.Read(buffer, 0, size);
                    MessageBase m = PacketMessageFactory.CreateMessage(kindValue, buffer);
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