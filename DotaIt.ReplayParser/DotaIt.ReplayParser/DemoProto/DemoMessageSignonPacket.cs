namespace DotaIt.ReplayParser.DemoProto
{
    using System.IO;

    using ProtoBuf;

    /// <summary>
    /// The demo message packet.
    /// </summary>
    public class DemoMessageSignonPacket : DemoMessageBase
    {
        private DemoMessagePacketProto _packetInfo;
        public DemoMessageSignonPacket(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_SignonPacket;
        }

        public new DemoMessagePacketProto MessageInstance
        {
            get
            {
                return _packetInfo;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _packetInfo = Helper.DeserilizedFromBytes<DemoMessagePacketProto>(Message);
        }

        public void BuildPacketMessageData()
        {
            
        }
    }

    [ProtoContract]
    public class DemoMessagePacketProto
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int SequenceIn { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int SequenceOutAck { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.Default)]
        public byte[] Data { get; set; }
    }
}