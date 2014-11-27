namespace DotaIt.ReplayParser.DemoProto.DemoMessages
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The demo message string tables.
    /// </summary>
    public class DemoMessageStringTables : DemoMessageBase
    {
        public DemoMessageStringTables(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_StringTables;;
        }

        private CDemoStringTables _stringTables;

        public new CDemoStringTables MessageInstance
        {
            get
            {
                return _stringTables;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _stringTables = Helper.DeserilizedFromBytes<CDemoStringTables>(Message);

            foreach (table_t table in _stringTables.tables)
            {
                int count = 0;
                foreach (items_t item in table.items)
                {
                    table.ItemsByIndex.Add(count, item);
                    table.ItemsByName.Add(item.str, item);
                    count++;
                }
            }
        }
    }
}