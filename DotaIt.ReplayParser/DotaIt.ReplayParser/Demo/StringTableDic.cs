namespace DotaIt.ReplayParser
{
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto.PacketMessage;

    public class StringTableDic
    {
        private List<SvcCreateStringTable> _byId = new List<SvcCreateStringTable>();

        private Dictionary<string, SvcCreateStringTable> _byName = new Dictionary<string, SvcCreateStringTable>();

        public List<SvcCreateStringTable> ById
        {
            get
            {
                return this._byId;
            }
        }

        public Dictionary<string, SvcCreateStringTable> ByName
        {
            get
            {
                return this._byName;
            }
        }

        public SvcCreateStringTable this[int id]
        {
            get
            {
                return _byId[id];
            }
        }

        public SvcCreateStringTable this[string name]
        {
            get
            {
                return _byName[name];
            }
        }

        public void Add(SvcCreateStringTable table)
        {
            this._byId.Add(table);
            this._byName.Add(table.Name, table);
        }
    }
}