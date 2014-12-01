namespace DotaIt.ReplayParser.Advanced
{
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The demo combat log.
    /// </summary>
    public class AbandonedCombatLogBase
    {
        public DOTA_COMBATLOG_TYPES CombatLogType { get; set; }

        public int SourceNameId { get; set; }

        public string SourceName { get; set; }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int InflictorNameId { get; set; }

        public string InflictorName { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int Value { get; set; }

        public int Health { get; set; }

        public float Time { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public bool IsAbilityToggleOn { get; set; }

        public bool IsAbilityToggleOff { get; set; }

        public int AbilityLevel { get; set; }

        public int GoldReason { get; set; }
    }
}