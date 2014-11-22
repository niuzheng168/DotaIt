namespace DotaIt.ReplayParser.DemoProto
{
    using System.IO;

    using ProtoBuf;

    /// <summary>
    /// The demo file info message.
    /// </summary>
    public class DemoMessageFileInfo : DemoMessageBase
    {
        #region Fields

        /// <summary>
        /// The _info.
        /// </summary>
        private DemoMessageFileInfoProto _info;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoMessageFileInfo"/> class.
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
        public DemoMessageFileInfo(DemoCommandKind kind, int tick, bool isCompressed, byte[] message)
            : base(kind, tick, isCompressed, message)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the message instance.
        /// </summary>
        public new DemoMessageFileInfoProto MessageInstance
        {
            get
            {
                return this._info;
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
                this._info = Serializer.Deserialize<DemoMessageFileInfoProto>(ms);
            }
        }

        #endregion
    }
}