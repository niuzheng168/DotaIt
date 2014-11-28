namespace DotaIt.ReplayParser
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The game event.
    /// </summary>
    public class GameEvent
    {
        public CSVCMsg_GameEventList.descriptor_t Descriptor { get; set; }
        
        public object[] State { get; set; }

        public int EventId { get; set; }

        public int Tick { get; set; }

        public GameEvent(int eventId, CSVCMsg_GameEventList.descriptor_t desc, int tick)
        {
            this.Descriptor = desc;
            this.State = new object[desc.keys.Count];
            this.EventId = eventId;
            this.Tick = tick;
        }
    }
}