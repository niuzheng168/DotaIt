namespace DotaIt.ReplayParser.Advanced.CombatLog
{
    using System.Text;

    using DotaIt.ReplayParser.Demo.CombatLog;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The demo combat log base.
    /// </summary>
    public abstract class DemoCombatLogBase
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(Order = -5)]
        public DOTA_COMBATLOG_TYPES Type { get; set; }

        [JsonProperty(Order = -10)]
        public float Time { get; set; }

        public const string CombatLog_Descriptor_Name = "dota_combatlog";

        public const string CombatLog_StringTable_Name = "CombatLogNames";

        public abstract void Parse(GameEvent combatEvent, DemoCombatLogHelper helper);

        public override string ToString()
        {
            return string.Format("Time: {0}, Type: {1}", Time, this.Type);
        }
    }

    public class DemoCombatLogDamage : DemoCombatLogBase
    {
        public DemoCombatLogDamage()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DAMAGE;
        }

        public int SourceNameId { get; set; }

        public string SourceName { get; set; }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int CauseId { get; set; }

        public string Cause { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int Value { get; set; }

        public int Health { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }


        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.SourceNameId = combatEvent.GetEventProperty<int>(helper.SourceNameIdx);
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.AttackerNameId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.CauseId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.Value = combatEvent.GetEventProperty<int>(helper.ValueIdx);
            this.Health = combatEvent.GetEventProperty<int>(helper.HealthIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.SourceName = helper.ConvertIdToString(this.SourceNameId);
            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.AttackerName = helper.ConvertIdToString(this.AttackerNameId);
            this.Cause = helper.ConvertIdToString(this.CauseId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogDamage ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogDamage damageLog = new DemoCombatLogDamage();
            damageLog.Parse(combatEvent, helper);

            return damageLog;
        }
    }

    public class DemoCombatLogITEM : DemoCombatLogBase
    {
        public DemoCombatLogITEM()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_ITEM;
        }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int UserId { get; set; }

        public string User { get; set; }

        public int ItemId { get; set; }

        public string Item { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }

        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.UserId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.ItemId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.User = helper.ConvertIdToString(this.UserId);
            this.Item = helper.ConvertIdToString(this.ItemId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogITEM ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogITEM ITEMLog = new DemoCombatLogITEM();
            ITEMLog.Parse(combatEvent, helper);

            return ITEMLog;
        }
    }

    public class DemoCombatLogAbility : DemoCombatLogBase
    {
        public DemoCombatLogAbility()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_ABILITY;
        }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int AbilityId { get; set; }

        public string Ability { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int IsDebuff { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }


        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);

            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.AttackerNameId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.AbilityId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.IsDebuff = combatEvent.GetEventProperty<int>(helper.ValueIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.AttackerName = helper.ConvertIdToString(this.AttackerNameId);
            this.Ability = helper.ConvertIdToString(this.AbilityId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogAbility ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogAbility abilityLog = new DemoCombatLogAbility();
            abilityLog.Parse(combatEvent, helper);

            return abilityLog;
        }
    }

    public class DemoCombatLogLocation : DemoCombatLogBase
    {
        public DemoCombatLogLocation()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_LOCATION;
        }

        public int SourceNameId { get; set; }

        public string SourceName { get; set; }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int ModifierId { get; set; }

        public string Modifier { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int Value { get; set; }

        public int Health { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }


        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.SourceNameId = combatEvent.GetEventProperty<int>(helper.SourceNameIdx);
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.AttackerNameId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.ModifierId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.Value = combatEvent.GetEventProperty<int>(helper.ValueIdx);
            this.Health = combatEvent.GetEventProperty<int>(helper.HealthIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.SourceName = helper.ConvertIdToString(this.SourceNameId);
            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.AttackerName = helper.ConvertIdToString(this.AttackerNameId);
            this.Modifier = helper.ConvertIdToString(this.ModifierId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogLocation ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogLocation locationLog = new DemoCombatLogLocation();
            locationLog.Parse(combatEvent, helper);

            return locationLog;
        }
    }

    public class DemoCombatLogHeal : DemoCombatLogBase
    {
        public DemoCombatLogHeal()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_HEAL;
        }

        public int SourceNameId { get; set; }

        public string SourceName { get; set; }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int ModifierId { get; set; }

        public string Modifier { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int Value { get; set; }

        public int Health { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }


        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.SourceNameId = combatEvent.GetEventProperty<int>(helper.SourceNameIdx);
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.AttackerNameId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.ModifierId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.Value = combatEvent.GetEventProperty<int>(helper.ValueIdx);
            this.Health = combatEvent.GetEventProperty<int>(helper.HealthIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.SourceName = helper.ConvertIdToString(this.SourceNameId);
            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.AttackerName = helper.ConvertIdToString(this.AttackerNameId);
            this.Modifier = helper.ConvertIdToString(this.ModifierId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogHeal ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogHeal healLog = new DemoCombatLogHeal();
            healLog.Parse(combatEvent, helper);

            return healLog;
        }
    }

    public class DemoCombatLogModifierAdd : DemoCombatLogBase
    {
        public DemoCombatLogModifierAdd()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_MODIFIER_ADD;
        }

        public int SourceNameId { get; set; }

        public string SourceName { get; set; }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int ModifierId { get; set; }

        public string Modifier { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int IsDebuff { get; set; }

        public int Health { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }


        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.SourceNameId = combatEvent.GetEventProperty<int>(helper.SourceNameIdx);
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.AttackerNameId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.ModifierId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.IsDebuff = combatEvent.GetEventProperty<int>(helper.ValueIdx);
            this.Health = combatEvent.GetEventProperty<int>(helper.HealthIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.SourceName = helper.ConvertIdToString(this.SourceNameId);
            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.AttackerName = helper.ConvertIdToString(this.AttackerNameId);
            this.Modifier = helper.ConvertIdToString(this.ModifierId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogModifierAdd ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogModifierAdd addMod = new DemoCombatLogModifierAdd();
            addMod.Parse(combatEvent, helper);

            return addMod;
        }
    }

    public class DemoCombatLogModifierRemove : DemoCombatLogBase
    {
        public DemoCombatLogModifierRemove()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_MODIFIER_REMOVE;
        }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int ModifierId { get; set; }

        public string Modifier { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int IsDebuff { get; set; }

        public int Health { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }


        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.AttackerNameId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.ModifierId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.IsDebuff = combatEvent.GetEventProperty<int>(helper.ValueIdx);
            this.Health = combatEvent.GetEventProperty<int>(helper.HealthIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.AttackerName = helper.ConvertIdToString(this.AttackerNameId);
            this.Modifier = helper.ConvertIdToString(this.ModifierId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogModifierRemove ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogModifierRemove removeMod = new DemoCombatLogModifierRemove();
            removeMod.Parse(combatEvent, helper);

            return removeMod;
        }
    }

    public class DemoCombatLogDeath : DemoCombatLogBase
    {
        public DemoCombatLogDeath()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DEATH;
        }

        public int SourceNameId { get; set; }

        public string SourceName { get; set; }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int AttackerNameId { get; set; }

        public string AttackerName { get; set; }

        public int CauseId { get; set; }

        public string Cause { get; set; }

        public bool IsAttacterIllusion { get; set; }

        public bool IsTargetIllusion { get; set; }

        public int TargetSourceNameId { get; set; }

        public string TargetSourceName { get; set; }

        public bool IsAttackerHero { get; set; }

        public bool IsTargetHero { get; set; }

        public int AbilityLevel { get; set; }


        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.SourceNameId = combatEvent.GetEventProperty<int>(helper.SourceNameIdx);
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.AttackerNameId = combatEvent.GetEventProperty<int>(helper.AttackerNameIdx);
            this.CauseId = combatEvent.GetEventProperty<int>(helper.InflictorNameIdx);
            this.IsAttacterIllusion = combatEvent.GetEventProperty<bool>(helper.AttackerIllusionIdx);
            this.IsTargetIllusion = combatEvent.GetEventProperty<bool>(helper.TargetIllusionIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.TargetSourceNameId = combatEvent.GetEventProperty<int>(helper.TargetSourceNameIdx);
            this.IsAttackerHero = combatEvent.GetEventProperty<bool>(helper.AttackerHeroIdx);
            this.IsTargetHero = combatEvent.GetEventProperty<bool>(helper.TargetHeroIdx);
            this.AbilityLevel = combatEvent.GetEventProperty<int>(helper.AbilityLevelIdx);

            this.SourceName = helper.ConvertIdToString(this.SourceNameId);
            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
            this.AttackerName = helper.ConvertIdToString(this.AttackerNameId);
            this.Cause = helper.ConvertIdToString(this.CauseId);
            this.TargetSourceName = helper.ConvertIdToString(this.TargetSourceNameId);
        }

        public static DemoCombatLogDeath ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogDeath deathLog = new DemoCombatLogDeath();
            deathLog.Parse(combatEvent, helper);

            return deathLog;
        }
    }

    public class DemoCombatLogPurchase : DemoCombatLogBase
    {
        public DemoCombatLogPurchase()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_PURCHASE;
        }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int ItemId { get; set; }

        public string Item { get; set; }

        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.ItemId = combatEvent.GetEventProperty<int>(helper.ValueIdx);

            this.Item = helper.ConvertIdToString(this.ItemId);
            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
        }

        public static DemoCombatLogPurchase ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogPurchase purchaseLog = new DemoCombatLogPurchase();
            purchaseLog.Parse(combatEvent, helper);

            return purchaseLog;
        }
    }

    public class DemoCombatLogGold : DemoCombatLogBase
    {
        public DemoCombatLogGold()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_GOLD;
        }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int Value { get; set; }

        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.Value = combatEvent.GetEventProperty<int>(helper.ValueIdx);

            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
        }

        public static DemoCombatLogGold ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogGold goldLog = new DemoCombatLogGold();
            goldLog.Parse(combatEvent, helper);

            return goldLog;
        }
    }

    public class DemoCombatLogXP : DemoCombatLogBase
    {
        public DemoCombatLogXP()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_XP;
        }

        public int TargetNameId { get; set; }

        public string TargetName { get; set; }

        public int Value { get; set; }

        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.TargetNameId = combatEvent.GetEventProperty<int>(helper.TargetNameIdx);
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.Value = combatEvent.GetEventProperty<int>(helper.ValueIdx);

            this.TargetName = helper.ConvertIdToString(this.TargetNameId);
        }

        public static DemoCombatLogXP ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogXP xpLog = new DemoCombatLogXP();
            xpLog.Parse(combatEvent, helper);

            return xpLog;
        }
    }

    public class DemoCombatLogGameState : DemoCombatLogBase
    {
        public DemoCombatLogGameState()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_GAME_STATE;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public CombatLogGameState State { get; set; }

        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.State = (CombatLogGameState)combatEvent.GetEventProperty<int>(helper.ValueIdx);
        }

        public static DemoCombatLogGameState ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogGameState stateLog = new DemoCombatLogGameState();
            stateLog.Parse(combatEvent, helper);

            return stateLog;
        }
    }

    public class DemoCombatLogBuyback : DemoCombatLogBase
    {
        public DemoCombatLogBuyback()
        {
            this.Type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_BUYBACK;
        }


        public int HeroId { get; set; }

        public string HeroName { get; set; }

        public float BuybackTime { get; set; }

        public override void Parse(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            this.Time = combatEvent.GetEventProperty<float>(helper.TimestampIdx);
            this.HeroId = combatEvent.GetEventProperty<int>(helper.ValueIdx);
            this.BuybackTime = combatEvent.GetEventProperty<int>(helper.TimestampRawIdx);

            this.HeroName = helper.ConvertIdToString(this.HeroId);
        }

        public static DemoCombatLogBuyback ParseFrom(GameEvent combatEvent, DemoCombatLogHelper helper)
        {
            DemoCombatLogBuyback buybackLog = new DemoCombatLogBuyback();
            buybackLog.Parse(combatEvent, helper);

            return buybackLog;
        }
    }
}