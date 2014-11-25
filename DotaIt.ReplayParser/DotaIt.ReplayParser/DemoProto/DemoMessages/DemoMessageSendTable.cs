namespace DotaIt.ReplayParser.DemoProto
{
    using System.Collections.Generic;
    using System.IO;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The demo message send table.
    /// </summary>
    public class DemoMessageSendTable : DemoMessageBase, IPacked
    {
        private CDemoSendTables _tables;
        private List<MessageBase> _unpackedMessageList = new List<MessageBase>();
        public DemoMessageSendTable(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_SendTables;
        }

        public new CDemoSendTables MessageInstance
        {
            get
            {
                return _tables;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _tables = Helper.DeserilizedFromBytes<CDemoSendTables>(Message);
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
                    MessageBase m = PacketMessage.CreateMessage(kindValue, buffer);
                    if (m != null)
                    {
                        m.BuildMessageInstance();
                        _unpackedMessageList.Add(m);
                    }
                }
            }
        }

        public List<MessageBase> UnpackedMessageList
        {
            get
            {
                return _unpackedMessageList;
            }
        }
    }
}