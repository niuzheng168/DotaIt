namespace DotaIt.ReplayParser
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using DotaIt.ReplayParser.DemoProto;
    using DotaIt.ReplayParser.DemoProto.PacketMessage;

    /// <summary>
    ///     The parser.
    /// </summary>
    public class Parser
    {
        public delegate void GetNewDemoMessageEventHandler(object sender, NewDemoMessageEventArgs args);

        public event GetNewDemoMessageEventHandler OnGetNewDemoMessage;

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

        private int _curTick = -1;

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
            // Sink to where the replay data start.
            this._demoReader.SetReaderStartPos(12);

            // This buffer stored all demo message in same tick.
            // We may need process more than one demo message in same tick.
            List<DemoMessageBase> _buffer = new List<DemoMessageBase>();

            while (this._demoReader.IsEnd)
            {
                // Read new message.
                DemoMessageBase message = this._demoReader.ReadDemoMessage();

                // If new message not belong to current tick
                // Process current buffer first.
                if (message.Tick > _curTick)
                {
                    ProcessMessageListInSameTick(_buffer);
                    _buffer.Clear();
                    _curTick = message.Tick;
                }

                // Add current message to buffer.
                _buffer.Add(message);
            }

            // Check the remaining buffer.
            if (_buffer.Count > 0)
            {
                ProcessMessageListInSameTick(_buffer);
            }
        }

        private void ProcessMessageListInSameTick(List<DemoMessageBase> demoMessageBases)
        {
            foreach (DemoMessageBase message in demoMessageBases)
            {
                if (message is IAnalysable)
                {
                    ((IAnalysable)message).AnalysisMessage(this._demo);
                }
                else if (message is IPacked)
                {
                    this.ProcessPackedDemoMessage((IPacked)message);
                }
                else
                {
                    Console.WriteLine(message.KindValue);
                }
            }

            _demo.PublishCurrentData();
        }

        private void ProcessPackedDemoMessage(IPacked message)
        {
            message.Unpack();
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
    }

    public class NewDemoMessageEventArgs : EventArgs
    {
        public NewDemoMessageEventArgs(DemoMessageBase message)
        {
            this.DemoMessage = message;
        }

        public DemoMessageBase DemoMessage { get; set; }
    }
}