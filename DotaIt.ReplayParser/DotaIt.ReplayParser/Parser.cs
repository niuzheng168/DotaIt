namespace DotaIt.ReplayParser
{
    using System;
    using System.IO;
    using System.Text;

    using DotaIt.ReplayParser.Protobuf;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using ProtoBuf;

    using Snappy;

    /// <summary>
    ///     The parser.
    /// </summary>
    public class Parser
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Parser"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public Parser(byte[] data)
        {
            this.Data = data;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Gets or sets the header length.
        /// </summary>
        public int HeaderLength { get; set; }

        /// <summary>
        /// Gets or sets the reader.
        /// </summary>
        public BinaryReader Reader { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The exlude header.
        /// </summary>
        public void ExludeHeader()
        {
            this.Data = this.Data.SubArray(this.HeaderLength, this.Data.Length - this.HeaderLength);

            // set binary reader
            this.Reader = new BinaryReader(new MemoryStream(this.Data));
        }

        /// <summary>
        /// The get header.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public void GetHeader()
        {
            this.Reader = new BinaryReader(new MemoryStream(this.Data));
            byte[] headerBytes = Reader.ReadBytes(8);
            string str = Encoding.UTF8.GetString(headerBytes, 0, headerBytes.Length);
            byte[] offsetBytes = Reader.ReadBytes(4);
            uint offset = BitConverter.ToUInt32(offsetBytes, 0);
            Reader.BaseStream.Seek(offset, SeekOrigin.Begin);

            int t1 = ProtoReader.DirectReadVarintInt32(Reader.BaseStream);
            t1 = t1 & (~112);
            int t2 = ProtoReader.DirectReadVarintInt32(Reader.BaseStream);
            int t3 = ProtoReader.DirectReadVarintInt32(Reader.BaseStream);
            byte[] data = Reader.ReadBytes(t3);
            data = SnappyCodec.Uncompress(data);
            MemoryStream ms = new MemoryStream(data);
            var info = Serializer.Deserialize<DemoFileInfo>(ms);

            string json = JsonConvert.SerializeObject(info);
        }

        #endregion
    }
}