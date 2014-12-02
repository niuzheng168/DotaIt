namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcSendTable : PacketMessageBase, IAnalysable
    {
        public SvcSendTable(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_SendTable _sendTable;

        public new CSVCMsg_SendTable MessageInstance
        {
            get
            {
                return this._sendTable;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._sendTable = Helper.DeserilizedFromBytes<CSVCMsg_SendTable>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();

            for (int i = 0; i < _sendTable.props.Count; i++)
            {
                sendprop_t prop = _sendTable.props[i];
                prop.Table = this._sendTable;
                prop.Template = prop.type == (int)PropType.Array ? _sendTable.props[i - 1] : null;
            }

            demo.DtClasses.Add(this._sendTable);
        }
    }
}