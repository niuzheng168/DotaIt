namespace DotaIt.ReplayParser
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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

        private Dictionary<int, string> _fields = new Dictionary<int, string>();

        public Dictionary<int, string> Fields
        {
            get
            {
                return this._fields;
            }
        }

        public GameEvent(int eventId, CSVCMsg_GameEventList.descriptor_t desc, int tick)
        {
            this.Descriptor = desc;
            this.State = new object[desc.keys.Count];
            this.EventId = eventId;
            this.Tick = tick;

            for (int i = 0; i < desc.keys.Count; i++)
            {
                _fields.Add(i, desc.keys[i].name);
            }
        }

        public T GetEventProperty<T>(int idx)
        {
            try
            {
                T prop = (T)this.State[idx];
                return prop;
            }
            catch
            {
                return default(T);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Time: {0}, Event Id: {1}, Event Name: {2}", Tick, EventId, Descriptor.name));
            foreach (KeyValuePair<int, string> pair in Fields)
            {
                sb.AppendLine(string.Format("{0}={1}", pair.Value, State[pair.Key]));
            }

            return sb.ToString();
        }
    }
}