namespace DotaIt.ReplayParser.DemoProto
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;

    using DotaIt.ReplayParser.Demo;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The send table flattener.
    /// </summary>
    public class SendTableFlattener
    {
        private DTClassDic _lookUp;

        private CSVCMsg_SendTable _descendant;

        private HashSet<SendTableExclusion> _exclusions;

        private List<ReceiveProp> _receiveProps = new List<ReceiveProp>();

        private StringBuilder nameBuf = new StringBuilder();

        public SendTableFlattener(DTClassDic lookUp, CSVCMsg_SendTable table)
        {
            this._lookUp = lookUp;
            this._descendant = table;
            this._exclusions = this.AggregateExclusions(table);
        }

        public List<ReceiveProp> Flatten()
        {
            this.Flatten(_descendant, new List<sendprop_t>(), new List<string>(), null);
            return this.Sort();
        }

        private List<ReceiveProp> Sort()
        {
            List<ReceiveProp> sorted = new List<ReceiveProp>(_receiveProps);
            HashSet<int> priorities = new HashSet<int>();
            priorities.Add(64);

            foreach (ReceiveProp receiveProp in sorted)
            {
                priorities.Add(receiveProp.SendProp.priority);
            }

            int offset = 0;
            foreach (int priority in priorities)
            {
                int hole = offset;
                int cursor = offset;
                while (cursor < sorted.Count)
                {
                    ReceiveProp rp = sorted[cursor];
                    bool changesOften = rp.SendProp.HasFlag(PropFlag.ChangesOften) && priority == 64;
                    if (changesOften || rp.SendProp.priority == priority)
                    {
                        sorted.Swap(cursor, hole);
                        hole++;
                        offset++;
                    }
                    cursor++;
                }
            }

            return sorted;
        }

        private void FlatternCollapsible(
            CSVCMsg_SendTable ancestor,
            List<sendprop_t> accumulator,
            List<string> path,
            string src)
        {
            foreach (sendprop_t sp in ancestor.GetAllNonExclusions())
            {
                bool excluded = _exclusions.Contains(new SendTableExclusion(ancestor.net_table_name, sp.var_name));
                bool ineligible = sp.HasFlag(PropFlag.InsideArray);
                if (excluded || ineligible)
                {
                    continue;
                }

                if (sp.type == (int)PropType.DataTable)
                {
                    if (sp.HasFlag(PropFlag.Collapsible))
                    {
                        this.FlatternCollapsible(_lookUp[sp.dt_name], accumulator, path, src);
                    }
                    else
                    {
                        path.Add(sp.var_name);
                        this.Flatten(_lookUp[sp.dt_name], new List<sendprop_t>(), path, src ?? ancestor.net_table_name);
                        path.RemoveAt(path.Count - 1);
                    }
                }
                else
                {
                    accumulator.Add(sp);
                }
            }
        }

        private void Flatten(CSVCMsg_SendTable ancestor, List<sendprop_t> accumulator, List<string> path, string src)
        {
            this.FlatternCollapsible(ancestor, accumulator, path, src);
            nameBuf = new StringBuilder();
            foreach (string part in path)
            {
                nameBuf.Append(part);
                nameBuf.Append(".");
            }

            int l = nameBuf.Length;
            foreach (sendprop_t sp in accumulator)
            {
                nameBuf.Append(sp.var_name);
                _receiveProps.Add(new ReceiveProp(sp, src ?? sp.Table.net_table_name, nameBuf.ToString()));
                nameBuf.Clear();
            }
        }

        private HashSet<SendTableExclusion> AggregateExclusions(CSVCMsg_SendTable table)
        {
            HashSet<SendTableExclusion> result = table.GetAllExclusions();
            foreach (sendprop_t sp in table.GetAllRelations())
            {
                result.UnionWith(this.AggregateExclusions(_lookUp[sp.dt_name]));
            }

            return result;
        }
    }

    public class SendTableExclusion
    {
        public string DtName { get; set; }
        public string VarName { get; set; }

        public SendTableExclusion(string dtName, string varName)
        {
            this.DtName = dtName;
            this.VarName = varName;
        }
    }

    public class ReceiveProp : IProp
    {
        public sendprop_t SendProp { get; set; }

        public string Source { get; set; }

        public string Name { get; set; }

        public ReceiveProp(sendprop_t prop, string source, string name)
        {
            this.SendProp = prop;
            this.Source = source;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format(
                "Source={0}, Name={1}, Type={2}, Prio={3}",
                Source,
                Name,
                (PropType)SendProp.type,
                SendProp.priority);
        }

        public bool HasFlag(PropFlag flag)
        {
            throw new System.NotImplementedException();
        }

        public int type { get; set; }

        public string src { get; private set; }

        public string dt_name { get; set; }

        public string var_name { get; set; }

        public int priority { get; set; }

        public float low_value { get; set; }

        public float high_value { get; set; }

        public int num_bits { get; set; }

        public sendprop_t Template { get; set; }

        public int num_elements { get; set; }

        public int flags { get; set; }
    }
}