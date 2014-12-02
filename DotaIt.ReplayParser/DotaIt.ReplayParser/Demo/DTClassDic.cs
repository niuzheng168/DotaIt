namespace DotaIt.ReplayParser.Demo
{
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The dt class dic.
    /// </summary>
    public class DTClassDic
    {
        private Dictionary<int, CSVCMsg_SendTable> _byId = new Dictionary<int, CSVCMsg_SendTable>();

        public Dictionary<int, CSVCMsg_SendTable> ById
        {
            get
            {
                return this._byId;
            }
        }

        public Dictionary<string, CSVCMsg_SendTable> _byName = new Dictionary<string, CSVCMsg_SendTable>();

        public Dictionary<string, CSVCMsg_SendTable> ByName
        {
            get
            {
                return this._byName;
            }
        }

        public CSVCMsg_SendTable this[int id]
        {
            get
            {
                return _byId[id];
            }
        }

        public CSVCMsg_SendTable this[string name]
        {
            get
            {
                return _byName[name];
            }
        }

        public void Add(CSVCMsg_SendTable talbe)
        {
            this._byName.Add(talbe.net_table_name, talbe);
        }

        public void SetClassIdForDtName(string name, int id)
        {
            CSVCMsg_SendTable table = _byName[name];
            table.ClassId = id;
            _byId.Add(id, table);
        }
    }
}