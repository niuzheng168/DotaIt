namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The demo message send table.
    /// </summary>
    public class DemoMessageSendTable : DemoMessageBase, IPacked
    {
        private CDemoSendTables _tables;
        private List<PacketMessageBase> _unpackedMessageList = new List<PacketMessageBase>();
        public DemoMessageSendTable(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_SendTables;
        }

        public new CDemoSendTables MessageInstance
        {
            get
            {
                return _tables;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _tables = Helper.DeserilizedFromBytes<CDemoSendTables>(Message);
        }

        public void Unpack()
        {
            this.BuildMessageInstance();
            using (MemoryStream ms = new MemoryStream(this.MessageInstance.data))
            {
                while (ms.Position < ms.Length)
                {
                    int kindValue = ProtoReader.DirectReadVarintInt32(ms);
                    int size = ProtoReader.DirectReadVarintInt32(ms);
                    byte[] buffer = new byte[size];
                    ms.Read(buffer, 0, size);
                    PacketMessageBase m = PacketMessageFactory.CreatePacketMessage(kindValue, buffer, _tick);
                    if (m != null)
                    {
                        _unpackedMessageList.Add(m);
                    }
                }
            }
        }

        public List<PacketMessageBase> UnpackedMessageList
        {
            get
            {
                return _unpackedMessageList;
            }
        }
    }

    //public class SendTable : DemoSVCMassage<CSVCMsg_SendTable>
    //{
    //    public SendTable(int kindValue, byte[] message)
    //        : base(kindValue, message)
    //    {
    //    }

    //    public new static SendTable Create(int kind, byte[] message)
    //    {
    //        SendTable st = new SendTable(kind, message);
    //        return st;
    //    }

    //    public override void BuildMessageInstance()
    //    {
    //        base.BuildMessageInstance();
    //        foreach (sendprop_t prop in MessageInstance.props)
    //        {
    //            prop.OriginalSendTable = this.MessageInstance.net_table_name;
    //        }
    //    }

    //    public IEnumerable<sendprop_t> DataTableProps
    //    {
    //        get
    //        {
    //            return this.NoExclusionProps.Where(sendprop_t.IsDataTable.Compile());
    //        }
    //    }

    //    public IEnumerable<sendprop_t> NoExclusionProps
    //    {
    //        get
    //        {
    //            return this.MessageInstance.props.Where(sendprop_t.IsNotExclude.Compile());
    //        }
    //    }

    //    public IEnumerable<sendprop_t> Exlusions()
    //    {
    //        // TODO

    //        List<sendprop_t> props = new List<sendprop_t>();
    //        foreach (sendprop_t pr in this.MessageInstance.props.Where(sendprop_t.IsExclude.Compile()))
    //        {
                
    //        }

    //        return props;
    //    }
    //}

    //public class Flattener
    //{
    //    public Dictionary<string, SendTable> SendTables { get; set; }

    //    public Flattener(Dictionary<string, SendTable> sts)
    //    {
    //        this.SendTables = sts;
    //    }

    //    public List<sendprop_t> Flatten(SendTable st)
    //    {
    //        List<sendprop_t> props = new List<sendprop_t>();

    //        // TODO

    //        return props;
    //    }

    //    private List<sendprop_t> AggregateExclusions(SendTable st)
    //    {
    //        List<sendprop_t> props = new List<sendprop_t>();

    //        foreach (sendprop_t prop in st.DataTableProps)
    //        {
    //            //SendTable table = this.SendTables[prop.dt_name];
    //            //props.AddRange(this.AggregateExclusions(table));
    //            // TODO
    //        }

    //        return props;
    //    }
    //}

    public class ReciveTable
    {
        public string Name { get; set; }
        public List<sendprop_t> Props { get; set; }

        public List<int> Priorities { get; set; }

        public ReciveTable(string name, List<sendprop_t> props)
        {
            this.Name = name;
            this.Props = props;
            
            this.Priorities = new List<int>();
            this.Priorities.Add(64);

            foreach (sendprop_t prop in Props)
            {
                if (this.Priorities.Contains(prop.priority))
                {
                    this.Priorities.Add(prop.priority);
                }
            }

            this.Priorities.Sort();
            int offset = 0;

            foreach (int pr in Priorities)
            {
                int proplen = this.Props.Count;
                int hole = offset;
                int cursor = offset;

                while (cursor < proplen)
                {
                    var p = this.Props[cursor];
                    bool isCo = 
                        pr == 64 && 
                        ((PropFlag)p.flags).HasFlag(PropFlag.ChangesOften);

                    if (isCo || p.priority == pr)
                    {
                        this.Props.Swap(hole, cursor);
                        hole++;
                        cursor++;
                    }

                    cursor++;
                }
            }
        }
    }
}