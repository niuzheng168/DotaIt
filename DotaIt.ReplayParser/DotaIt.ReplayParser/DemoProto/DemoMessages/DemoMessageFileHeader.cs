namespace DotaIt.ReplayParser.DemoProto
{
    using System.IO;

    using ProtoBuf;

    /// <summary>
    ///     The demo message file header.
    /// </summary>
    public class DemoMessageFileHeader : DemoMessageBase, IAnalysable
    {
        #region Fields

        /// <summary>
        /// The _header.
        /// </summary>
        private DemoMessageFileHeaderProto _header;

        #endregion

        #region Constructors and Destructors

        public DemoMessageFileHeader(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_FileHeader;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the message instance.
        /// </summary>
        public new DemoMessageFileHeaderProto MessageInstance
        {
            get
            {
                return this._header;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The build message instance.
        /// </summary>
        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._header = Helper.DeserilizedFromBytes<DemoMessageFileHeaderProto>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();
            demo.FileHeader = this;
        }

        #endregion
    }

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