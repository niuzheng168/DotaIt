namespace DotaIt.ReplayParser.Demo.CombatLog
{
    using System.Diagnostics;
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    public class DemoCombatLogHelper
    {
        public SvcCreateStringTable CombatLogTable { get; set; }

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

        public DemoCombatLogHelper(SvcCreateStringTable stringTable, CSVCMsg_GameEventList.descriptor_t descriptor)
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

        public DemoCombatLogBase CreateCombatLog(GameEvent combatEvent)
        {
            return CreateCombatLog(combatEvent, this);
        }

        public static DemoCombatLogBase CreateCombatLog(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            int combatlogType = combatEvent.GetEventProperty<int>(helper.TypeIdx);
            DemoCombatLogBase log = null;
            switch (combatlogType)
            {
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_ABILITY:
                    log = DemoCombatLogAbility.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_BUYBACK:
                    log = DemoCombatLogBuyback.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DAMAGE:
                    log = DemoCombatLogDamage.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DEATH:
                    log = DemoCombatLogDeath.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_GAME_STATE:
                    log = DemoCombatLogGameState.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_GOLD:
                    log = DemoCombatLogGold.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_HEAL:
                    log = DemoCombatLogHeal.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_ITEM:
                    log = DemoCombatLogITEM.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_LOCATION:
                    log = DemoCombatLogLocation.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_MODIFIER_ADD:
                    log = DemoCombatLogModifierAdd.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_MODIFIER_REMOVE:
                    log = DemoCombatLogModifierRemove.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_PURCHASE:
                    log = DemoCombatLogPurchase.ParseFrom(combatEvent, helper);
                    break;
                case (int)DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_XP:
                    log = DemoCombatLogXP.ParseFrom(combatEvent, helper);
                    break;
                default:
                    Debug.WriteLine("Unknown combat log type {0}", combatEvent);
                    break;
            }

            return log;
        }

    }
}