namespace DotaIt.ReplayParser.DemoProto.DemoMessages
{
    using System.Collections.Generic;
    using System.IO;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The demo message full packet.
    /// </summary>
    public class DemoMessageFullPacket : DemoMessageBase
    {
        public DemoMessageFullPacket(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_FullPacket;
        }

        public void Unpack()
        {

        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _packet = Helper.DeserilizedFromBytes<CDemoFullPacket>(Message);
        }

        private CDemoFullPacket _packet;

        public new CDemoFullPacket MessageInstance
        {
            get
            {
                return _packet;
            }
        }

        private List<MessageBase> _unpackedMessageList =new List<MessageBase>();

        public List<MessageBase> UnpackedMessageList
        {
            get
            {
                return _unpackedMessageList;
            }
        }
    }
}