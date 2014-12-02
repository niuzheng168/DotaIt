namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using System.IO;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcGameEvent : PacketMessageBase, IAnalysable
    {
        public SvcGameEvent(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_GameEvent _gameEvent;

        public new CSVCMsg_GameEvent MessageInstance
        {
            get
            {
                return this._gameEvent;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._gameEvent = Helper.DeserilizedFromBytes<CSVCMsg_GameEvent>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();

            int eventId = this._gameEvent.eventid;
            CSVCMsg_GameEventList.descriptor_t desc = demo.GameEventDescriptors[eventId];
            GameEvent gameEvent = new GameEvent(eventId, desc, _tick);

            for (int i = 0; i < this.MessageInstance.keys.Count; i++)
            {
                CSVCMsg_GameEvent.key_t key = this._gameEvent.keys[i];
                object value = null;
                switch (key.type)
                {
                    case 1:
                        value = key.val_string;
                        break;
                    case 2:
                        value = key.val_float;
                        break;
                    case 3:
                        value = key.val_long;
                        break;
                    case 4:
                        value = key.val_short;
                        break;
                    case 5:
                        value = key.val_byte;
                        break;
                    case 6:
                        value = key.val_bool;
                        break;
                    case 7:
                        value = key.val_uint64;
                        break;
                    default:
                        throw new InvalidDataException();
                }

                gameEvent.State[i] = value;
            }

            demo.GameEvents.Add(gameEvent);
        }
    }
}