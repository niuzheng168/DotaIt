namespace DotaIt.ReplayParser
{
    using System.Collections.Generic;
    using System.Linq;

    using DotaIt.ReplayParser.Demo;
    using DotaIt.ReplayParser.DemoProto;
    using DotaIt.ReplayParser.DemoProto.DemoMessages;
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The foreplay.
    /// </summary>
    public class DemoInfo
    {
        private List<DemoMessageBase> _demoMessageList = new List<DemoMessageBase>();

        public List<DemoMessageBase> DemoMessageList
        {
            get
            {
                return this._demoMessageList;
            }
        }

        private DemoMessageFileHeader _fileHeader;

        public DemoMessageFileHeader FileHeader
        {
            get
            {
                return this._fileHeader;
            }
        }

        private List<DemoMessageSignonPacket> _signonPacketMessageList = new List<DemoMessageSignonPacket>();

        private List<PacketMessageBase> _packets = new List<PacketMessageBase>();

        public List<PacketMessageBase> Packets
        {
            get
            {
                return this._packets;
            }
        }

        private GameEventDescriptorDic _gameEventDescriptors = new GameEventDescriptorDic();

        public GameEventDescriptorDic GameEventDescriptors
        {
            get
            {
                return this._gameEventDescriptors;
            }
        }

        private StringTableDic _stringTables = new StringTableDic();

        public StringTableDic StringTables
        {
            get
            {
                return this._stringTables;
            }
        }

        private DotaMofifierDic _modifiers = new DotaMofifierDic();

        public DotaMofifierDic Modifiers
        {
            get
            {
                return this._modifiers;
            }
        }

        private SvcServerInfo _serverInfo;

        public SvcServerInfo ServerInfo
        {
            get
            {
                return this._serverInfo;
            }
        }

        private SvcVoiceInit _voiceInit;

        public SvcVoiceInit VoiceInit
        {
            get
            {
                return this._voiceInit;
            }
        }

        private List<DemoMessageSendTable> _sendTablesMessageList = new List<DemoMessageSendTable>();

        private Dictionary<string, SvcSendTable> _sendTables = new Dictionary<string, SvcSendTable>();

        public Dictionary<string, SvcSendTable> SendTables
        {
            get
            {
                return this._sendTables;
            }
        }

        private List<DemoMessageClassInfo> _classInfoMessageList = new List<DemoMessageClassInfo>();

        private Dictionary<int, CDemoClassInfo.class_t> _classInfo = new Dictionary<int, CDemoClassInfo.class_t>();

        public Dictionary<int, CDemoClassInfo.class_t> ClassInfo
        {
            get
            {
                return this._classInfo;
            }
        }

        private Dictionary<int, ReciveTable> _reciveTables = new Dictionary<int, ReciveTable>();

        public Dictionary<int, ReciveTable> ReciveTables
        {
            get
            {
                return this._reciveTables;
            }
        }

        private List<GameEvent> _gameEvents = new List<GameEvent>();

        public List<GameEvent> GameEvents
        {
            get
            {
                return this._gameEvents;
            }
        }

        public void Initialize()
        {
            this._fileHeader =
                this._demoMessageList.FirstOrDefault(x => x.Kind == DemoCommandKind.DEM_FileHeader) as
                DemoMessageFileHeader;

            this.ProcessSignonPackets();
            this.ProcessSendTables();
            this.ProcessClassInfo();
            this.ProcessStringTables();
        }

        private void ProcessClassInfo()
        {
            this.DemoMessageList.Where(x => x.Kind == DemoCommandKind.DEM_ClassInfo).ToList().ForEach(
                y =>
                    {
                        y.BuildMessageInstance();
                        this._classInfoMessageList.Add(y as DemoMessageClassInfo);
                    });

            this._classInfoMessageList.ForEach(
                x => x.MessageInstance.classes.ForEach(y => this.ClassInfo.Add(y.class_id, y)));
        }

        private void ProcessSignonPackets()
        {
            this._demoMessageList.Where(x => x.Kind == DemoCommandKind.DEM_SignonPacket).ToList().ForEach(
                y =>
                    {
                        y.BuildMessageInstance();
                        this._signonPacketMessageList.Add(y as DemoMessageSignonPacket);
                    });

            this._signonPacketMessageList.ForEach(
                x =>
                    {
                        x.Unpack(true);
                        this._packets.AddRange(x.UnpackedMessageList);
                    });

            foreach (PacketMessageBase messageBase in this._packets.Where(x => x.KindValue == (int)SVC_Messages_Kind.svc_GameEventList))
            {
                SvcGameEventList m = messageBase as SvcGameEventList;
                foreach (var desc in m.MessageInstance.descriptors)
                {
                    this._gameEventDescriptors.Add(desc);
                }
            }

            this._serverInfo =
                this._packets.FirstOrDefault(x => x.KindValue == (int)SVC_Messages_Kind.svc_ServerInfo) as
                SvcServerInfo;

            this._voiceInit = this._packets.FirstOrDefault(x => x.KindValue == (int)SVC_Messages_Kind.svc_VoiceInit) as
                SvcVoiceInit;
        }

        private void ProcessSendTables()
        {
            this._demoMessageList.Where(x => x.Kind == DemoCommandKind.DEM_SendTables).ToList().ForEach(
                y =>
                    {
                        y.BuildMessageInstance();
                        this._sendTablesMessageList.Add(y as DemoMessageSendTable);
                    });

            this._sendTablesMessageList.ForEach(
                x =>
                    {
                        x.Unpack(true);
                        foreach (PacketMessageBase message in x.UnpackedMessageList)
                        {
                            SvcSendTable m = message as SvcSendTable;
                            if (m.MessageInstance.is_end)
                            {
                                break;
                            }

                            this._sendTables.Add(m.MessageInstance.net_table_name, m);
                        }
                    });
        }

        public void ProcessStringTables()
        {
            this.Packets.Where(x => x.KindValue == (int)SVC_Messages_Kind.svc_CreateStringTable).ToList().ForEach(
                y =>
                    {
                        SvcCreateStringTable message = y as SvcCreateStringTable;
                        message.BuildMessageInstance();
                        this._stringTables.Add(message);
                        message.AnalysisMessage(this);
                    });
        }

        public void UpdateStringTable(int id, List<StringTableItem> list)
        {
            SvcCreateStringTable table = this._stringTables[id];
            UpdateStringTable(table, list);
        }

        public void UpdateStringTable(string name, List<StringTableItem> list)
        {
            SvcCreateStringTable table = this._stringTables[name];
            UpdateStringTable(table, list);
        }

        private void UpdateStringTable(SvcCreateStringTable table, List<StringTableItem> list)
        {
            foreach (StringTableItem item in list)
            {
                if (table.Name == "ActiveModifiers")
                {
                    if (item.Value == null)
                    {
                        return;
                    }
                    CDOTAModifierBuffTableEntry mod = Helper.DeserilizedFromBytes<CDOTAModifierBuffTableEntry>(item.Value.ToByteArray());
                    this._modifiers.Add(mod);
                }
                else
                {
                    table.SetValue(item.Index, item.Key, item.Value);
                }
            }
        }
    }
}