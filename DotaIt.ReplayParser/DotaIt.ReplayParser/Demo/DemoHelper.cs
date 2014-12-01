namespace DotaIt.ReplayParser
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    using DotaIt.ReplayParser.Advanced;
    using DotaIt.ReplayParser.Advanced.CombatLog;
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using Newtonsoft.Json;

    /// <summary>
    /// The demo helper.
    /// </summary>
    public static class DemoHelper
    {
        public const string CombatLog_Descriptor_Name = "dota_combatlog";
        public const string CombatLog_StringTable_Name = "CombatLogNames";

        public static List<AbandonedCombatLogBase> ExtractCombatLogs(DemoInfo demo)
        {
            CSVCMsg_GameEventList.descriptor_t descriptor = demo.GameEventDescriptors[CombatLog_Descriptor_Name];
            SvcCreateStringTable stringTable = demo.StringTables[CombatLog_StringTable_Name];
            DemoCombatLogHelper combatLogHelper = new DemoCombatLogHelper(stringTable, descriptor);

            var list = demo.GameEvents.Where(x => x.EventId == descriptor.eventid);

            using (StreamWriter sw = new StreamWriter(@"d:\combatlog.json", false, Encoding.Unicode))
            {
                foreach (GameEvent combatEvent in list)
                {
                    DemoCombatLogBase logBase = combatLogHelper.CreateCombatLog(combatEvent);
                    sw.WriteLine(JsonConvert.SerializeObject(logBase, new JsonSerializerSettings() { Formatting = Formatting.Indented }));
                }
            }

            return null;
        }
    }
}