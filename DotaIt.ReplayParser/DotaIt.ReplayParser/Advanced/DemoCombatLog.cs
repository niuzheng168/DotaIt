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

        public DemoCombatLog(GameEvent rawEvent)
        {
            this._rawEvent = rawEvent;
        }
    }

    public class DemoCombatLogHelper
    {
        public table_t CombatLogTable { get; set; }

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

        public DemoCombatLogHelper(table_t stringTable, CSVCMsg_GameEventList.descriptor_t descriptor)
        {
            this.CombatLogTable = stringTable;

            this.TypeIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.SourceNameIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.TargetHeroIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.AttackerNameIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.InflictorNameIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.AttackerIllusionIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.TargetIllusionIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.ValueIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.HealthIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.TimestampIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.TargetSourceNameIdx = descriptor.keys.FindIndex(x => x.name == "type");

            this.TimestampRawIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.AttackerHeroIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.TargetHeroIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.AbilityToggleOnIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.AbilityToggleOffIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.AbilityLevelIdx = descriptor.keys.FindIndex(x => x.name == "type");
            this.GoldReasonIdx = descriptor.keys.FindIndex(x => x.name == "type");
        }
    }
}