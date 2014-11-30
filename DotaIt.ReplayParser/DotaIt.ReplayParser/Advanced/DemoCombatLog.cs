namespace DotaIt.ReplayParser.Advanced
{
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The demo combat log.
    /// </summary>
    public class DemoCombatLog
    {
        private GameEvent _rawEvent;

        public GameEvent RawEvent
        {
            get
            {
                return this._rawEvent;
            }
        }

        public DemoCombatLog(int type)
        {
            CombatLogType = (DOTA_COMBATLOG_TYPES)type;
        }

        public DOTA_COMBATLOG_TYPES CombatLogType { get; set; }
        public int SourceNameId { get; set; }

        public int TargetNameId { get; set; }
    }

    public class DemoCombatLogHelper
    {
        public StringTable CombatLogTable { get; set; }

        public int TypeIdx { get; set; }

        public int SourceNameIdx { get; set; }

        public int TargetNameIdx { get; set; }

        public int AttackerNameIdx { get; set; }

        public int InflictorNameIdx { get; set; }

        public int AttackerIllusionIdx { get; set; }

        public int TargetIllusionIdx { get; set; }

        public int ValueIdx { get; set; }

        public int HealthIdx { get; set; }

        public int TimestampIdx { get; set; }

        public int TargetSourceNameIdx { get; set; }

        public int TimestampRawIdx { get; set; }

        public int AttackerHeroIdx { get; set; }

        public int TargetHeroIdx { get; set; }

        public int AbilityToggleOnIdx { get; set; }

        public int AbilityToggleOffIdx { get; set; }

        public int AbilityLevelIdx { get; set; }

        public int GoldReasonIdx { get; set; }

        public DemoCombatLogHelper(StringTable stringTable, CSVCMsg_GameEventList.descriptor_t descriptor)
        {
            this.CombatLogTable = stringTable;

            this.TypeIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.SourceNameIdx = descriptor.keys.FindIndex(x => x.name == "sourcename");
            this.TargetNameIdx = descriptor.keys.FindIndex(x => x.name == "targetname");
            this.AttackerNameIdx = descriptor.keys.FindIndex(x => x.name == "attackername");
            this.InflictorNameIdx = descriptor.keys.FindIndex(x => x.name == "inflictorname");
            this.AttackerIllusionIdx = descriptor.keys.FindIndex(x => x.name == "attackerillusion");
            this.TargetIllusionIdx = descriptor.keys.FindIndex(x => x.name == "targetillusion");
            this.ValueIdx = descriptor.keys.FindIndex(x => x.name == "value");
            this.HealthIdx = descriptor.keys.FindIndex(x => x.name == "health");
            this.TimestampIdx = descriptor.keys.FindIndex(x => x.name == "timestamp");
            this.TargetSourceNameIdx = descriptor.keys.FindIndex(x => x.name == "targetsourcename");

            this.TimestampRawIdx = descriptor.keys.FindIndex(x => x.name == "timestampraw");
            this.AttackerHeroIdx = descriptor.keys.FindIndex(x => x.name == "attackerhero");
            this.TargetHeroIdx = descriptor.keys.FindIndex(x => x.name == "targethero");
            this.AbilityToggleOnIdx = descriptor.keys.FindIndex(x => x.name == "ability_toggle_on");
            this.AbilityToggleOffIdx = descriptor.keys.FindIndex(x => x.name == "ability_toggle_off");
            this.AbilityLevelIdx = descriptor.keys.FindIndex(x => x.name == "ability_level");
            this.GoldReasonIdx = descriptor.keys.FindIndex(x => x.name == "gold_reason");
        }

        public string ConvertIdToString(int id)
        {
            return this.CombatLogTable.Names[id];
        }
    }
}