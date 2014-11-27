namespace DotaIt.ReplayParser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography;

    using DotaIt.ReplayParser.DemoProto;
    using DotaIt.ReplayParser.DemoProto.DemoMessages;
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
        private DemoForeplay _foreplay;

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
            while (_demoReader.IsEnd)
            {
                DemoMessageBase message = this._demoReader.ReadDemoMessage();
                if (message is DemoMessageFullPacket)
                {
                    DemoMessageFullPacket fullPacket = message as DemoMessageFullPacket;
                    DemoMessageFactory.CreateDemoMessage((int)DemoCommandKind.DEM_Packet, fullPacket.Tick, fullPacket.MessageInstance.packet.);
                }
                else if (message is IPacked)
                {
                    message.BuildMessageInstance();
                    IPacked m = message as IPacked;
                    m.Unpack();
                    foreach (MessageBase messageBase in m.UnpackedMessageList)
                    {
                        var et = messageBase as DemoSVCMassage<CSVCMsg_GameEvent>;
                        if (et != null)
                        {
                            this.GetGameEvent(et);
                        }
                        else
                        {
                            Console.WriteLine(messageBase.KindValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine(message.KindValue);
                }
            }
        }

        private void GetGameEvent(DemoSVCMassage<CSVCMsg_GameEvent> et)
        {
            int eventId = et.MessageInstance.eventid;
            var desc = this._foreplay.GameEventList[eventId];
            GameEvent gameEvent = new GameEvent(desc);
            for (int i = 0; i < et.MessageInstance.keys.Count; i++)
            {
                CSVCMsg_GameEvent.key_t key = et.MessageInstance.keys[i];
                object value = null;
                switch (key.type)
                {
                    case 1:
                        value = key.val_string;
                        break;
                    case 2:
                        value = key.val_float;
                        break;
                    case 3:
                        value = key.val_long;
                        break;
                    case 4:
                        value = key.val_short;
                        break;
                    case 5:
                        value = key.val_byte;
                        break;
                    case 6:
                        value = key.val_bool;
                        break;
                    case 7:
                        value = key.val_uint64;
                        break;
                    default:
                        throw new InvalidDataException();
                }
                gameEvent.State[i] = value;
            }

            this._gameEvents.Add(gameEvent);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The build foreplay.
        /// </summary>
        private void BuildForeplay()
        {
            this._foreplay = new DemoForeplay();
            while (true)
            {
                var message = this._demoReader.ReadDemoMessage();
                if (message.KindValue == (int)DemoCommandKind.DEM_SyncTick)
                {
                    break;
                }

                this._foreplay.DemoMessageList.Add(message);
            }

            this._foreplay.Initialize();
        }
        #endregion
    }
}