namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    using DotaIt.ReplayParser.DemoProto.DemoMessages;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The foreplay.
    /// </summary>
    public class DemoForeplay
    {
        private List<DemoMessageBase> _demoMessageList = new List<DemoMessageBase>();

        public List<DemoMessageBase> DemoMessageList
        {
            get
            {
                return this._demoMessageList;
            }
        }

        public DemoMessageFileHeader _fileHeader;

        public DemoMessageFileHeader FileHeader
        {
            get
            {
                return this._fileHeader;
            }
        }

        private List<DemoMessageSignonPacket> _signonPacketMessageList = new List<DemoMessageSignonPacket>();

        private List<MessageBase> _packets = new List<MessageBase>();

        public List<MessageBase> Packets
        {
            get
            {
                return this._packets;
            }
        }

        private Dictionary<int, CSVCMsg_GameEventList.descriptor_t> _gameEventList =
            new Dictionary<int, CSVCMsg_GameEventList.descriptor_t>();

        public Dictionary<int, CSVCMsg_GameEventList.descriptor_t> GameEventList
        {
            get
            {
                return _gameEventList;
            }
        }

        private DemoSVCMassage<CSVCMsg_ServerInfo> _serverInfo;

        public DemoSVCMassage<CSVCMsg_ServerInfo> ServerInfo
        {
            get
            {
                return this._serverInfo;
            }
        }

        private DemoSVCMassage<CSVCMsg_VoiceInit> _voiceInit;
        public DemoSVCMassage<CSVCMsg_VoiceInit> VoiceInit
        {
            get
            {
                return this._voiceInit;
            }
        }

        private List<DemoMessageSendTable> _sendTablesMessageList = new List<DemoMessageSendTable>();

        private Dictionary<string, DemoSVCMassage<CSVCMsg_SendTable>> _sendTables = new Dictionary<string, DemoSVCMassage<CSVCMsg_SendTable>>();

        public Dictionary<string, DemoSVCMassage<CSVCMsg_SendTable>> SendTables
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

        private List<DemoMessageStringTables> _stringTableMessageList = new List<DemoMessageStringTables>();

        private Dictionary<string, table_t> _stringTables = new Dictionary<string, table_t>();

        public Dictionary<string, table_t> StringTables
        {
            get
            {
                return _stringTables;
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
                        x.Unpack();
                        this._packets.AddRange(x.UnpackedMessageList);
                    });

            foreach (MessageBase messageBase in this._packets.Where(x => x.KindValue == (int)SVC_Messages_Kind.svc_GameEventList))
            {
                DemoSVCMassage<CSVCMsg_GameEventList> m = messageBase as DemoSVCMassage<CSVCMsg_GameEventList>;
                foreach (var desc in m.MessageInstance.descriptors)
                {
                    this._gameEventList.Add(desc.eventid, desc);
                }
            }

            this._serverInfo =
                this._packets.FirstOrDefault(x => x.KindValue == (int)SVC_Messages_Kind.svc_ServerInfo) as
                DemoSVCMassage<CSVCMsg_ServerInfo>;

            this._voiceInit = this._packets.FirstOrDefault(x => x.KindValue == (int)SVC_Messages_Kind.svc_VoiceInit) as
                DemoSVCMassage<CSVCMsg_VoiceInit>;
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
                        x.Unpack();
                        foreach (MessageBase message in x.UnpackedMessageList)
                        {
                            DemoSVCMassage<CSVCMsg_SendTable> m = message as DemoSVCMassage<CSVCMsg_SendTable>;
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
            this._demoMessageList.Where(x => x.Kind == DemoCommandKind.DEM_StringTables).ToList().ForEach(
                y =>
                    {
                        y.BuildMessageInstance();
                        this._stringTableMessageList.Add(y as DemoMessageStringTables);
                    });

            this._stringTableMessageList.ForEach(
                x => x.MessageInstance.tables.ForEach(
                    y => this._stringTables.Add(y.table_name, y)));
        }
    }
}