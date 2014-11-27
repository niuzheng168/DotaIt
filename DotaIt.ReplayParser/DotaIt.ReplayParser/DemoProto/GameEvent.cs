namespace DotaIt.ReplayParser.DemoProto
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The game event.
    /// </summary>
    public class GameEvent
    {
        public CSVCMsg_GameEventList.descriptor_t Descriptor { get; set; }
        public object[] State { get; set; }

        public GameEvent(CSVCMsg_GameEventList.descriptor_t desc)
        {
            this.Descriptor = desc;
            this.State = new object[desc.keys.Count];
        }
    }
}