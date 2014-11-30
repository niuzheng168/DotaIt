namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcUpdateStringTable : PacketMessageBase, IAnalysable
    {
        public SvcUpdateStringTable(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_UpdateStringTable _updateStringTable;

        public new CSVCMsg_UpdateStringTable MessageInstance
        {
            get
            {
                return this._updateStringTable;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._updateStringTable = Helper.DeserilizedFromBytes<CSVCMsg_UpdateStringTable>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            int id = this.MessageInstance.table_id;
            SvcCreateStringTable table = demo.StringTables[id];
            var list = SvcCreateStringTable.DecodeFromData(
                table,
                this.MessageInstance.string_data,
                this.MessageInstance.num_changed_entries);
            demo.UpdateStringTable(id, list);
        }
    }
}