namespace DotaIt.ReplayParser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography;

    using DotaIt.ReplayParser.DemoProto;
    using DotaIt.ReplayParser.DemoProto.DemoMessages;
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    ///     The parser.
    /// </summary>
    public class Parser
    {
        #region Fields

        /// <summary>
        /// The _demo reader.
        /// </summary>
        private DemoReader _demoReader;

        /// <summary>
        /// The _foreplay.
        /// </summary>
        private DemoInfo _demo = new DemoInfo();

        /// <summary>
        /// The _fs.
        /// </summary>
        private FileStream _fs;

        private List<GameEvent> _gameEvents = new List<GameEvent>();

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Parser"/> class.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        public Parser(string path)
        {
            this.DemoFilePath = path;
            this._fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            this._demoReader = new DemoReader(this._fs);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the demo file path.
        /// </summary>
        public string DemoFilePath { get; set; }

        public DemoInfo Demo
        {
            get
            {
                return this._demo;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The directly read file info.
        /// </summary>
        /// <returns>
        ///     The <see cref="DemoMessageFileInfo" />.
        ///     File info.
        /// </returns>
        public DemoMessageFileInfo DirectlyReadFileInfo()
        {
            return this._demoReader.ReadDemoFileInfo();
        }

        /// <summary>
        ///     The get header.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        ///     Header String.
        /// </returns>
        public string GetDemoHeader()
        {
            return this._demoReader.GetHeader();
        }

        /// <summary>
        /// The parse.
        /// </summary>
        public void Parse()
        {
            this._demoReader.SetReaderStartPos(12);
            this.BuildForeplay();
            while (this._demoReader.IsEnd)
            {
                DemoMessageBase message = this._demoReader.ReadDemoMessage();
                if (message is DemoMessageFullPacket)
                {
                    
                }
                else if (message is DemoMessagePacket)
                {
                    message.BuildMessageInstance();
                    this.ProcessPackedDemoMessage((IPacked)message);
                }
                else
                {
                    Console.WriteLine(message.KindValue);
                }
            }
        }

        private void ProcessPackedDemoMessage(IPacked message)
        {
            message.Unpack(true);
            foreach (PacketMessageBase packedMessage in message.UnpackedMessageList)
            {
                var analysableMessage = packedMessage as IAnalysable;
                if (analysableMessage != null)
                {
                    analysableMessage.AnalysisMessage(this._demo);
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The build foreplay.
        /// </summary>
        private void BuildForeplay()
        {
            while (true)
            {
                var message = this._demoReader.ReadDemoMessage();
                if (message.KindValue == (int)DemoCommandKind.DEM_SyncTick)
                {
                    break;
                }

                this._demo.DemoMessageList.Add(message);
            }

            this._demo.Initialize();
        }
        #endregion
    }
}