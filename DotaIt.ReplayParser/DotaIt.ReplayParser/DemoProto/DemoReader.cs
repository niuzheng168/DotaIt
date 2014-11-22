namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.IO;
    using System.Text;

    using ProtoBuf;

    /// <summary>
    ///     The demo reader.
    /// </summary>
    public class DemoReader
    {
        #region Constants

        /// <summary>
        /// The header length.
        /// </summary>
        public const int HeaderLength = 8;

        #endregion

        #region Fields

        /// <summary>
        /// The _demo file info offset.
        /// </summary>
        private int _demoFileInfoOffset = -1;

        /// <summary>
        /// The _fs.
        /// </summary>
        private FileStream _fs;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoReader"/> class.
        /// </summary>
        /// <param name="fs">
        /// The fs.
        /// </param>
        public DemoReader(FileStream fs)
        {
            this._fs = fs;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The get header.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetHeader()
        {
            byte[] buffer = new byte[8];
            this._fs.Read(buffer, 0, HeaderLength);
            return Encoding.UTF8.GetString(buffer, 0, HeaderLength);
        }

        /// <summary>
        /// The read demo file info.
        /// </summary>
        /// <returns>
        /// The <see cref="DemoMessageFileInfo"/>.
        /// </returns>
        public DemoMessageFileInfo ReadDemoFileInfo()
        {
            if (this._demoFileInfoOffset == -1)
            {
                this.SetReaderStartPos(8);
                byte[] buffer = new byte[4];
                this._fs.Read(buffer, 0, 4);
                this._demoFileInfoOffset = BitConverter.ToInt32(buffer, 0);
            }

            this.SetReaderStartPos(this._demoFileInfoOffset);
            DemoMessageFileInfo message = this.ReadDemoMessage() as DemoMessageFileInfo;
            if (message != null)
            {
                message.BuildMessageInstance();
            }

            return message;
        }

        /// <summary>
        /// The read demo message.
        /// </summary>
        /// <returns>
        /// The <see cref="DemoMessageBase"/>.
        /// </returns>
        public DemoMessageBase ReadDemoMessage()
        {
            int kindValue = ProtoReader.DirectReadVarintInt32(this._fs);
            int tick = ProtoReader.DirectReadVarintInt32(this._fs);
            int messageSize = ProtoReader.DirectReadVarintInt32(this._fs);
            byte[] messageBody = new byte[messageSize];
            this._fs.Read(messageBody, 0, messageSize);

            var RealKind = DemoMessageBase.RealKind(kindValue);
            DemoCommandKind kind = RealKind.Item1;
            bool isCompressed = RealKind.Item2;
            DemoMessageBase messageBase = DemoMessageFactory.CreateDemoMessage(kind, tick, messageBody, isCompressed);

            return messageBase;
        }

        /// <summary>
        /// The set reader start pos.
        /// </summary>
        /// <param name="pos">
        /// The pos.
        /// </param>
        public void SetReaderStartPos(int pos)
        {
            this._fs.Seek(pos, SeekOrigin.Begin);
        }

        #endregion
    }
}