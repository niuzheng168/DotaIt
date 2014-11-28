namespace DotaIt.ReplayParser
{
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The game event descriptor dic.
    /// </summary>
    public class GameEventDescriptorDic
    {
        private Dictionary<int, CSVCMsg_GameEventList.descriptor_t> _byEventId = new Dictionary<int, CSVCMsg_GameEventList.descriptor_t>();

        private Dictionary<string, CSVCMsg_GameEventList.descriptor_t> _byEventName = new Dictionary<string, CSVCMsg_GameEventList.descriptor_t>();

        public CSVCMsg_GameEventList.descriptor_t GetById(int id)
        {
            return this._byEventId[id];
        }

        public CSVCMsg_GameEventList.descriptor_t GetByName(string name)
        {
            return this._byEventName[name];
        }

        public void Add(CSVCMsg_GameEventList.descriptor_t descriptor)
        {
            this._byEventId.Add(descriptor.eventid, descriptor);
            this._byEventName.Add(descriptor.name, descriptor);
        }

        public CSVCMsg_GameEventList.descriptor_t this[int id]
        {
            get
            {
                return this._byEventId[id];
            }
        }

        public CSVCMsg_GameEventList.descriptor_t this[string name]
        {
            get
            {
                return this._byEventName[name];
            }
        }
    }
}