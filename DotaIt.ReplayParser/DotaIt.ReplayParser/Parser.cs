namespace DotaIt.ReplayParser
{
    using System;
    using System.IO;
    using System.Text;

    using DotaIt.ReplayParser.DemoProto;

    using Newtonsoft.Json;

    using ProtoBuf;

    using Snappy;

    /// <summary>
    ///     The parser.
    /// </summary>
    public class Parser
    {
        private FileStream _fs;

        private DemoReader _demoReader;

        #region Constructors and Destructors

        public Parser(string path)
        {
            this.DemoFilePath = path;
            this._fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            this._demoReader = new DemoReader(_fs);
        }

        #endregion

        #region Public Properties

        public string DemoFilePath { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The get header.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// Header String.</returns>
        public string GetDemoHeader()
        {
            return _demoReader.GetHeader();
        }

        /// <summary>
        /// The directly read file info.
        /// </summary>
        /// <returns>
        /// The <see cref="DemoMessageFileInfo"/>.
        /// File info.</returns>
        public DemoMessageFileInfo DirectlyReadFileInfo()
        {
            return _demoReader.ReadDemoFileInfo();
        }

        #endregion
    }
}