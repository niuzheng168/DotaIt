namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

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

        private List<DemoMessageSignonPacket> _signonPacketMessageList = new List<DemoMessageSignonPacket>();

        //public List<DemoMessageSignonPacket> SignonPackets
        //{
        //    get
        //    {
        //        return this._signonPackets;
        //    }
        //}

        private List<MessageBase> _packets = new List<MessageBase>();

        public List<MessageBase> Packets
        {
            get
            {
                return this._packets;
            }
        }

        private List<DemoMessageSendTable> _sendTablesMessageList = new List<DemoMessageSendTable>();

        //public List<DemoMessageSendTable> SendTablesMessageList
        //{
        //    get
        //    {
        //        return this._sendTablesMessageList;
        //    }
        //}

        private Dictionary<string, DemoSVCMassage<CSVCMsg_SendTable>> _sendTables = new Dictionary<string, DemoSVCMassage<CSVCMsg_SendTable>>();

        public Dictionary<string, DemoSVCMassage<CSVCMsg_SendTable>> SendTables
        {
            get
            {
                return this._sendTables;
            }
        }

        private List<DemoMessageClassInfo> _classInfoMessageList = new List<DemoMessageClassInfo>();

        private Dictionary<string, DemoSVCMassage<CSVCMsg_ClassInfo>> _classInfo = new Dictionary<string, DemoSVCMassage<CSVCMsg_ClassInfo>>();

        public Dictionary<string, DemoSVCMassage<CSVCMsg_ClassInfo>> ClassInfo
        {
            get
            {
                return this._classInfo;
            }
        }

        public void Initialize()
        {
            this.ProcessSignonPackets();
            this.ProcessSendTables();
            this.ProcessClassInfo();
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
                x =>
                    {
                        x.Unpack();
                        foreach (MessageBase message in x.UnpackedMessageList)
                        {
                            DemoSVCMassage<CSVCMsg_SendTable> m = message as DemoSVCMassage<CSVCMsg_SendTable>;
                            this.SendTables.Add(m.MessageInstance.net_table_name, m);
                        }
                    });
        }

        private void ProcessSignonPackets()
        {
            this.DemoMessageList.Where(x => x.Kind == DemoCommandKind.DEM_SignonPacket).ToList().ForEach(
                y =>
                    {
                        y.BuildMessageInstance();
                        this._signonPacketMessageList.Add(y as DemoMessageSignonPacket);
                    });

            this._signonPacketMessageList.ForEach(
                x =>
                    {
                        x.Unpack();
                        this.Packets.AddRange(x.UnpackedMessageList);
                    });
        }

        private void ProcessSendTables()
        {
            this.DemoMessageList.Where(x => x.Kind == DemoCommandKind.DEM_SendTables).ToList().ForEach(
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
                            this.SendTables.Add(m.MessageInstance.net_table_name, m);
                        }
                    });
        }
    }
}