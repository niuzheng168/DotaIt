namespace DotaIt.ReplayParser
{
    using System.Collections.Generic;
    using System.Linq;

    using DotaIt.ReplayParser.Advanced;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The demo helper.
    /// </summary>
    public static class DemoHelper
    {
        public const string CombatLog_Descriptor_Name = "dota_combatlog";
        public const string CombatLog_StringTable_Name = "CombatLogNames";

        public static List<DemoCombatLog> ExtractCombatLogs(Demo demo)
        {
            CSVCMsg_GameEventList.descriptor_t descriptor = demo.GameEventDescriptors[CombatLog_Descriptor_Name];
            table_t stringTable = demo.StringTables[CombatLog_StringTable_Name];
            DemoCombatLogHelper combatLogHelper = new DemoCombatLogHelper(stringTable, descriptor);

            var list = demo.GameEvents.Where(x => x.EventId == descriptor.eventid);

            foreach (GameEvent combatEvent in list)
            {
                int CombatLogType = combatEvent.GetEventProperty<int>(combatLogHelper.TypeIdx);
                DemoCombatLog log = new DemoCombatLog(CombatLogType);
                int souceNameId = combatEvent.GetEventProperty<int>(combatLogHelper.SourceNameIdx);
                int targetNameId = combatEvent.GetEventProperty<int>(combatLogHelper.TargetNameIdx);
                int value = combatEvent.GetEventProperty<int>(combatLogHelper.ValueIdx);
                string name = combatLogHelper.ConvertIdToString(targetNameId);
            }

            return null;
        }
    }
}