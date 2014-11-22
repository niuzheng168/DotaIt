namespace DotaIt.ReplayParser.DemoProto
{
    using ProtoBuf;

    /// <summary>
    /// The demo message file header proto.
    /// </summary>
    [ProtoContract]
    public class DemoMessageFileHeaderProto
    {
        [ProtoMember(1, IsRequired = true, DataFormat = DataFormat.Default)]
        public string DemoFileStamp { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int NetWorkProtocol { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.Default)]
        public string ServerName { get; set; }

        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.Default)]
        public string ClientName { get; set; }

        [ProtoMember(5, IsRequired = false, DataFormat = DataFormat.Default)]
        public string MapName { get; set; }

        [ProtoMember(6, IsRequired = false, DataFormat = DataFormat.Default)]
        public string GameDirectory { get; set; }

        [ProtoMember(7, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int FullVersion { get; set; }

        [ProtoMember(8, IsRequired = false, DataFormat = DataFormat.Default)]
        public bool AllowClientSideEntities { get; set; }

        [ProtoMember(9, IsRequired = false, DataFormat = DataFormat.Default)]
        public bool AllowClientSideParticles { get; set; }
    }
}