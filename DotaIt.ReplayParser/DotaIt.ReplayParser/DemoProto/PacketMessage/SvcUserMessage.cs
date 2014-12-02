namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.DemoProto.UserMessage;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcUserMessage : PacketMessageBase, IAnalysable
    {
        public SvcUserMessage(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_UserMessage _userMsg;

        public new CSVCMsg_UserMessage MessageInstance
        {
            get
            {
                return this._userMsg;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._userMsg = Helper.DeserilizedFromBytes<CSVCMsg_UserMessage>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();
            UserMessageBase msg = UserMessageFactory.CreateUserMessage(_userMsg.msg_type, this.Tick, _userMsg.msg_data);
            if (msg != null)
            {
                demo.UserMessages.Add(msg);
            }
        }
    }
}