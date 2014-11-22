namespace DotaIt.ReplayParser.DemoProto
{
    using System.IO;

    using ProtoBuf;

    /// <summary>
    ///     The demo message file header.
    /// </summary>
    public class DemoMessageFileHeader : DemoMessageBase
    {
        #region Fields

        /// <summary>
        /// The _header.
        /// </summary>
        private DemoMessageFileHeaderProto _header;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoMessageFileHeader"/> class.
        /// </summary>
        /// <param name="kind">
        /// The kind.
        /// </param>
        /// <param name="tick">
        /// The tick.
        /// </param>
        /// <param name="isCompressed">
        /// The is compressed.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public DemoMessageFileHeader(DemoCommandKind kind, int tick, bool isCompressed, byte[] message)
            : base(kind, tick, isCompressed, message)
        {
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
            using (MemoryStream ms = new MemoryStream(this._message))
            {
                this._header = Serializer.Deserialize<DemoMessageFileHeaderProto>(ms);
            }
        }

        #endregion
    }
}