namespace DotaIt.ReplayParser.DemoProto.ProtoDef
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_AIDebugLine")]
    public partial class CDOTAUserMsg_AIDebugLine : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_AIDebugLine() { }

        private string _message = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_Ping")]
    public partial class CDOTAUserMsg_Ping : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_Ping() { }

        private string _message = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SwapVerify")]
    public partial class CDOTAUserMsg_SwapVerify : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SwapVerify() { }

        private uint _player_id = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ChatEvent")]
    public partial class CDOTAUserMsg_ChatEvent : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ChatEvent() { }

        private DOTA_CHAT_MESSAGE _type;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public DOTA_CHAT_MESSAGE type
        {
            get { return _type; }
            set { _type = value; }
        }
        private uint _value = default(uint);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint value
        {
            get { return _value; }
            set { _value = value; }
        }
        private int _playerid_1 = (int)-1;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"playerid_1", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        [global::System.ComponentModel.DefaultValue((int)-1)]
        public int playerid_1
        {
            get { return _playerid_1; }
            set { _playerid_1 = value; }
        }
        private int _playerid_2 = (int)-1;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"playerid_2", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        [global::System.ComponentModel.DefaultValue((int)-1)]
        public int playerid_2
        {
            get { return _playerid_2; }
            set { _playerid_2 = value; }
        }
        private int _playerid_3 = (int)-1;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"playerid_3", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        [global::System.ComponentModel.DefaultValue((int)-1)]
        public int playerid_3
        {
            get { return _playerid_3; }
            set { _playerid_3 = value; }
        }
        private int _playerid_4 = (int)-1;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"playerid_4", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        [global::System.ComponentModel.DefaultValue((int)-1)]
        public int playerid_4
        {
            get { return _playerid_4; }
            set { _playerid_4 = value; }
        }
        private int _playerid_5 = (int)-1;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"playerid_5", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        [global::System.ComponentModel.DefaultValue((int)-1)]
        public int playerid_5
        {
            get { return _playerid_5; }
            set { _playerid_5 = value; }
        }
        private int _playerid_6 = (int)-1;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"playerid_6", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        [global::System.ComponentModel.DefaultValue((int)-1)]
        public int playerid_6
        {
            get { return _playerid_6; }
            set { _playerid_6 = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_CombatLogData")]
    public partial class CDOTAUserMsg_CombatLogData : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_CombatLogData() { }

        private DOTA_COMBATLOG_TYPES _type = DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DAMAGE;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(DOTA_COMBATLOG_TYPES.DOTA_COMBATLOG_DAMAGE)]
        public DOTA_COMBATLOG_TYPES type
        {
            get { return _type; }
            set { _type = value; }
        }
        private uint _target_name = default(uint);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"target_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint target_name
        {
            get { return _target_name; }
            set { _target_name = value; }
        }
        private uint _attacker_name = default(uint);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"attacker_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint attacker_name
        {
            get { return _attacker_name; }
            set { _attacker_name = value; }
        }
        private bool _attacker_illusion = default(bool);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"attacker_illusion", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool attacker_illusion
        {
            get { return _attacker_illusion; }
            set { _attacker_illusion = value; }
        }
        private bool _target_illusion = default(bool);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"target_illusion", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool target_illusion
        {
            get { return _target_illusion; }
            set { _target_illusion = value; }
        }
        private uint _inflictor_name = default(uint);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"inflictor_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint inflictor_name
        {
            get { return _inflictor_name; }
            set { _inflictor_name = value; }
        }
        private int _value = default(int);
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int value
        {
            get { return _value; }
            set { _value = value; }
        }
        private int _health = default(int);
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"health", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int health
        {
            get { return _health; }
            set { _health = value; }
        }
        private float _time = default(float);
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float time
        {
            get { return _time; }
            set { _time = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_CombatLogShowDeath")]
    public partial class CDOTAUserMsg_CombatLogShowDeath : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_CombatLogShowDeath() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_BotChat")]
    public partial class CDOTAUserMsg_BotChat : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_BotChat() { }

        private uint _player_id = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private string _format = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"format", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string format
        {
            get { return _format; }
            set { _format = value; }
        }
        private string _message = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private string _target = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"target", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string target
        {
            get { return _target; }
            set { _target = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_CombatHeroPositions")]
    public partial class CDOTAUserMsg_CombatHeroPositions : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_CombatHeroPositions() { }

        private uint _index = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint index
        {
            get { return _index; }
            set { _index = value; }
        }
        private int _time = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int time
        {
            get { return _time; }
            set { _time = value; }
        }
        private CMsgVector2D _world_pos = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"world_pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector2D world_pos
        {
            get { return _world_pos; }
            set { _world_pos = value; }
        }
        private int _health = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"health", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int health
        {
            get { return _health; }
            set { _health = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_MiniKillCamInfo")]
    public partial class CDOTAUserMsg_MiniKillCamInfo : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_MiniKillCamInfo() { }

        private readonly global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker> _attackers = new global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker>();
        [global::ProtoBuf.ProtoMember(1, Name = @"attackers", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker> attackers
        {
            get { return _attackers; }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Attacker")]
        public partial class Attacker : global::ProtoBuf.IExtensible
        {
            public Attacker() { }

            private uint _attacker = default(uint);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"attacker", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint attacker
            {
                get { return _attacker; }
                set { _attacker = value; }
            }
            private int _total_damage = default(int);
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"total_damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int total_damage
            {
                get { return _total_damage; }
                set { _total_damage = value; }
            }
            private readonly global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker.Ability> _abilities = new global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker.Ability>();
            [global::ProtoBuf.ProtoMember(3, Name = @"abilities", DataFormat = global::ProtoBuf.DataFormat.Default)]
            public global::System.Collections.Generic.List<CDOTAUserMsg_MiniKillCamInfo.Attacker.Ability> abilities
            {
                get { return _abilities; }
            }

            [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Ability")]
            public partial class Ability : global::ProtoBuf.IExtensible
            {
                public Ability() { }

                private uint _ability = default(uint);
                [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"ability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
                [global::System.ComponentModel.DefaultValue(default(uint))]
                public uint ability
                {
                    get { return _ability; }
                    set { _ability = value; }
                }
                private int _damage = default(int);
                [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
                [global::System.ComponentModel.DefaultValue(default(int))]
                public int damage
                {
                    get { return _damage; }
                    set { _damage = value; }
                }
                private global::ProtoBuf.IExtension extensionObject;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
            }

            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_GlobalLightColor")]
    public partial class CDOTAUserMsg_GlobalLightColor : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_GlobalLightColor() { }

        private uint _color = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint color
        {
            get { return _color; }
            set { _color = value; }
        }
        private float _duration = default(float);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_GlobalLightDirection")]
    public partial class CDOTAUserMsg_GlobalLightDirection : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_GlobalLightDirection() { }

        private CMsgVector _direction = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"direction", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        private float _duration = default(float);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_LocationPing")]
    public partial class CDOTAUserMsg_LocationPing : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_LocationPing() { }

        private uint _player_id = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private CDOTAMsg_LocationPing _location_ping = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"location_ping", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAMsg_LocationPing location_ping
        {
            get { return _location_ping; }
            set { _location_ping = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ItemAlert")]
    public partial class CDOTAUserMsg_ItemAlert : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ItemAlert() { }

        private uint _player_id = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private CDOTAMsg_ItemAlert _item_alert = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"item_alert", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAMsg_ItemAlert item_alert
        {
            get { return _item_alert; }
            set { _item_alert = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_MinimapEvent")]
    public partial class CDOTAUserMsg_MinimapEvent : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_MinimapEvent() { }

        private int _event_type = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"event_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int event_type
        {
            get { return _event_type; }
            set { _event_type = value; }
        }
        private int _entity_handle = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entity_handle
        {
            get { return _entity_handle; }
            set { _entity_handle = value; }
        }
        private int _x = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        private int _duration = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_MapLine")]
    public partial class CDOTAUserMsg_MapLine : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_MapLine() { }

        private int _player_id = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private CDOTAMsg_MapLine _mapline = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"mapline", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAMsg_MapLine mapline
        {
            get { return _mapline; }
            set { _mapline = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_MinimapDebugPoint")]
    public partial class CDOTAUserMsg_MinimapDebugPoint : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_MinimapDebugPoint() { }

        private CMsgVector _location = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"location", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector location
        {
            get { return _location; }
            set { _location = value; }
        }
        private uint _color = default(uint);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint color
        {
            get { return _color; }
            set { _color = value; }
        }
        private int _size = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int size
        {
            get { return _size; }
            set { _size = value; }
        }
        private float _duration = default(float);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_CreateLinearProjectile")]
    public partial class CDOTAUserMsg_CreateLinearProjectile : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_CreateLinearProjectile() { }

        private CMsgVector _origin = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"origin", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector origin
        {
            get { return _origin; }
            set { _origin = value; }
        }
        private CMsgVector2D _velocity = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"velocity", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector2D velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }
        private int _latency = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"latency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int latency
        {
            get { return _latency; }
            set { _latency = value; }
        }
        private int _entindex = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entindex
        {
            get { return _entindex; }
            set { _entindex = value; }
        }
        private int _particle_index = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"particle_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int particle_index
        {
            get { return _particle_index; }
            set { _particle_index = value; }
        }
        private int _handle = default(int);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int handle
        {
            get { return _handle; }
            set { _handle = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_DestroyLinearProjectile")]
    public partial class CDOTAUserMsg_DestroyLinearProjectile : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_DestroyLinearProjectile() { }

        private int _handle = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int handle
        {
            get { return _handle; }
            set { _handle = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_DodgeTrackingProjectiles")]
    public partial class CDOTAUserMsg_DodgeTrackingProjectiles : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_DodgeTrackingProjectiles() { }

        private int _entindex;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int entindex
        {
            get { return _entindex; }
            set { _entindex = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SpectatorPlayerClick")]
    public partial class CDOTAUserMsg_SpectatorPlayerClick : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SpectatorPlayerClick() { }

        private int _entindex;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int entindex
        {
            get { return _entindex; }
            set { _entindex = value; }
        }
        private int _order_type = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"order_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int order_type
        {
            get { return _order_type; }
            set { _order_type = value; }
        }
        private int _target_index = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"target_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int target_index
        {
            get { return _target_index; }
            set { _target_index = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_NevermoreRequiem")]
    public partial class CDOTAUserMsg_NevermoreRequiem : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_NevermoreRequiem() { }

        private int _entity_handle = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entity_handle
        {
            get { return _entity_handle; }
            set { _entity_handle = value; }
        }
        private int _lines = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"lines", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int lines
        {
            get { return _lines; }
            set { _lines = value; }
        }
        private CMsgVector _origin = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"origin", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector origin
        {
            get { return _origin; }
            set { _origin = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_InvalidCommand")]
    public partial class CDOTAUserMsg_InvalidCommand : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_InvalidCommand() { }

        private string _message = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_HudError")]
    public partial class CDOTAUserMsg_HudError : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_HudError() { }

        private int _order_id = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"order_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SharedCooldown")]
    public partial class CDOTAUserMsg_SharedCooldown : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SharedCooldown() { }

        private int _entindex = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entindex
        {
            get { return _entindex; }
            set { _entindex = value; }
        }
        private string _name = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private float _cooldown = default(float);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"cooldown", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float cooldown
        {
            get { return _cooldown; }
            set { _cooldown = value; }
        }
        private int _name_index = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"name_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int name_index
        {
            get { return _name_index; }
            set { _name_index = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SetNextAutobuyItem")]
    public partial class CDOTAUserMsg_SetNextAutobuyItem : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SetNextAutobuyItem() { }

        private string _name = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_HalloweenDrops")]
    public partial class CDOTAUserMsg_HalloweenDrops : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_HalloweenDrops() { }

        private readonly global::System.Collections.Generic.List<uint> _item_defs = new global::System.Collections.Generic.List<uint>();
        [global::ProtoBuf.ProtoMember(1, Name = @"item_defs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<uint> item_defs
        {
            get { return _item_defs; }
        }

        private readonly global::System.Collections.Generic.List<uint> _player_ids = new global::System.Collections.Generic.List<uint>();
        [global::ProtoBuf.ProtoMember(2, Name = @"player_ids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<uint> player_ids
        {
            get { return _player_ids; }
        }

        private uint _prize_list = default(uint);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"prize_list", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint prize_list
        {
            get { return _prize_list; }
            set { _prize_list = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAResponseQuerySerialized")]
    public partial class CDOTAResponseQuerySerialized : global::ProtoBuf.IExtensible
    {
        public CDOTAResponseQuerySerialized() { }

        private readonly global::System.Collections.Generic.List<CDOTAResponseQuerySerialized.Fact> _facts = new global::System.Collections.Generic.List<CDOTAResponseQuerySerialized.Fact>();
        [global::ProtoBuf.ProtoMember(1, Name = @"facts", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CDOTAResponseQuerySerialized.Fact> facts
        {
            get { return _facts; }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Fact")]
        public partial class Fact : global::ProtoBuf.IExtensible
        {
            public Fact() { }

            private int _key;
            [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"key", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            public int key
            {
                get { return _key; }
                set { _key = value; }
            }
            private CDOTAResponseQuerySerialized.Fact.ValueType _valtype;
            [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"valtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            public CDOTAResponseQuerySerialized.Fact.ValueType valtype
            {
                get { return _valtype; }
                set { _valtype = value; }
            }
            private float _val_numeric = default(float);
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"val_numeric", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue(default(float))]
            public float val_numeric
            {
                get { return _val_numeric; }
                set { _val_numeric = value; }
            }
            private string _val_string = "";
            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"val_string", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string val_string
            {
                get { return _val_string; }
                set { _val_string = value; }
            }
            [global::ProtoBuf.ProtoContract(Name = @"ValueType")]
            public enum ValueType
            {

                [global::ProtoBuf.ProtoEnum(Name = @"NUMERIC", Value = 1)]
                NUMERIC = 1,

                [global::ProtoBuf.ProtoEnum(Name = @"STRING", Value = 2)]
                STRING = 2
            }

            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTASpeechMatchOnClient")]
    public partial class CDOTASpeechMatchOnClient : global::ProtoBuf.IExtensible
    {
        public CDOTASpeechMatchOnClient() { }

        private int _concept = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"concept", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int concept
        {
            get { return _concept; }
            set { _concept = value; }
        }
        private int _recipient_type = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"recipient_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int recipient_type
        {
            get { return _recipient_type; }
            set { _recipient_type = value; }
        }
        private CDOTAResponseQuerySerialized _responsequery = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"responsequery", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAResponseQuerySerialized responsequery
        {
            get { return _responsequery; }
            set { _responsequery = value; }
        }
        private int _randomseed = (int)0;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"randomseed", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue((int)0)]
        public int randomseed
        {
            get { return _randomseed; }
            set { _randomseed = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_UnitEvent")]
    public partial class CDOTAUserMsg_UnitEvent : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_UnitEvent() { }

        private EDotaEntityMessages _msg_type;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"msg_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public EDotaEntityMessages msg_type
        {
            get { return _msg_type; }
            set { _msg_type = value; }
        }
        private int _entity_index;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"entity_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int entity_index
        {
            get { return _entity_index; }
            set { _entity_index = value; }
        }
        private CDOTAUserMsg_UnitEvent.Speech _speech = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"speech", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_UnitEvent.Speech speech
        {
            get { return _speech; }
            set { _speech = value; }
        }
        private CDOTAUserMsg_UnitEvent.SpeechMute _speech_mute = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"speech_mute", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_UnitEvent.SpeechMute speech_mute
        {
            get { return _speech_mute; }
            set { _speech_mute = value; }
        }
        private CDOTAUserMsg_UnitEvent.AddGesture _add_gesture = null;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"add_gesture", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_UnitEvent.AddGesture add_gesture
        {
            get { return _add_gesture; }
            set { _add_gesture = value; }
        }
        private CDOTAUserMsg_UnitEvent.RemoveGesture _remove_gesture = null;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"remove_gesture", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_UnitEvent.RemoveGesture remove_gesture
        {
            get { return _remove_gesture; }
            set { _remove_gesture = value; }
        }
        private CDOTAUserMsg_UnitEvent.BloodImpact _blood_impact = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"blood_impact", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_UnitEvent.BloodImpact blood_impact
        {
            get { return _blood_impact; }
            set { _blood_impact = value; }
        }
        private CDOTAUserMsg_UnitEvent.FadeGesture _fade_gesture = null;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"fade_gesture", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_UnitEvent.FadeGesture fade_gesture
        {
            get { return _fade_gesture; }
            set { _fade_gesture = value; }
        }
        private CDOTASpeechMatchOnClient _speech_match_on_client = null;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"speech_match_on_client", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTASpeechMatchOnClient speech_match_on_client
        {
            get { return _speech_match_on_client; }
            set { _speech_match_on_client = value; }
        }
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Speech")]
        public partial class Speech : global::ProtoBuf.IExtensible
        {
            public Speech() { }

            private int _concept = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"concept", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int concept
            {
                get { return _concept; }
                set { _concept = value; }
            }
            private string _response = "";
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"response", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string response
            {
                get { return _response; }
                set { _response = value; }
            }
            private int _recipient_type = default(int);
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"recipient_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int recipient_type
            {
                get { return _recipient_type; }
                set { _recipient_type = value; }
            }
            private int _level = default(int);
            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int level
            {
                get { return _level; }
                set { _level = value; }
            }
            private bool _muteable = (bool)false;
            [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"muteable", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue((bool)false)]
            public bool muteable
            {
                get { return _muteable; }
                set { _muteable = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"SpeechMute")]
        public partial class SpeechMute : global::ProtoBuf.IExtensible
        {
            public SpeechMute() { }

            private float _delay = (float)0.5;
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"delay", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue((float)0.5)]
            public float delay
            {
                get { return _delay; }
                set { _delay = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"AddGesture")]
        public partial class AddGesture : global::ProtoBuf.IExtensible
        {
            public AddGesture() { }

            private Activity _activity = Activity.ACT_INVALID;
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Activity.ACT_INVALID)]
            public Activity activity
            {
                get { return _activity; }
                set { _activity = value; }
            }
            private int _slot = default(int);
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int slot
            {
                get { return _slot; }
                set { _slot = value; }
            }
            private float _fade_in = (float)0;
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"fade_in", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue((float)0)]
            public float fade_in
            {
                get { return _fade_in; }
                set { _fade_in = value; }
            }
            private float _fade_out = (float)0.1;
            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"fade_out", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue((float)0.1)]
            public float fade_out
            {
                get { return _fade_out; }
                set { _fade_out = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"RemoveGesture")]
        public partial class RemoveGesture : global::ProtoBuf.IExtensible
        {
            public RemoveGesture() { }

            private Activity _activity = Activity.ACT_INVALID;
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Activity.ACT_INVALID)]
            public Activity activity
            {
                get { return _activity; }
                set { _activity = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"BloodImpact")]
        public partial class BloodImpact : global::ProtoBuf.IExtensible
        {
            public BloodImpact() { }

            private int _scale = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"scale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int scale
            {
                get { return _scale; }
                set { _scale = value; }
            }
            private int _x_normal = default(int);
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"x_normal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int x_normal
            {
                get { return _x_normal; }
                set { _x_normal = value; }
            }
            private int _y_normal = default(int);
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"y_normal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int y_normal
            {
                get { return _y_normal; }
                set { _y_normal = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"FadeGesture")]
        public partial class FadeGesture : global::ProtoBuf.IExtensible
        {
            public FadeGesture() { }

            private Activity _activity = Activity.ACT_INVALID;
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Activity.ACT_INVALID)]
            public Activity activity
            {
                get { return _activity; }
                set { _activity = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ItemPurchased")]
    public partial class CDOTAUserMsg_ItemPurchased : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ItemPurchased() { }

        private int _item_index = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"item_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int item_index
        {
            get { return _item_index; }
            set { _item_index = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ItemFound")]
    public partial class CDOTAUserMsg_ItemFound : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ItemFound() { }

        private int _player = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player
        {
            get { return _player; }
            set { _player = value; }
        }
        private int _quality = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int quality
        {
            get { return _quality; }
            set { _quality = value; }
        }
        private int _rarity = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"rarity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int rarity
        {
            get { return _rarity; }
            set { _rarity = value; }
        }
        private int _method = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"method", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int method
        {
            get { return _method; }
            set { _method = value; }
        }
        private int _itemdef = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"itemdef", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int itemdef
        {
            get { return _itemdef; }
            set { _itemdef = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ParticleManager")]
    public partial class CDOTAUserMsg_ParticleManager : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ParticleManager() { }

        private DOTA_PARTICLE_MESSAGE _type;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public DOTA_PARTICLE_MESSAGE type
        {
            get { return _type; }
            set { _type = value; }
        }
        private uint _index;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public uint index
        {
            get { return _index; }
            set { _index = value; }
        }
        private CDOTAUserMsg_ParticleManager.ReleaseParticleIndex _release_particle_index = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"release_particle_index", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.ReleaseParticleIndex release_particle_index
        {
            get { return _release_particle_index; }
            set { _release_particle_index = value; }
        }
        private CDOTAUserMsg_ParticleManager.CreateParticle _create_particle = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"create_particle", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.CreateParticle create_particle
        {
            get { return _create_particle; }
            set { _create_particle = value; }
        }
        private CDOTAUserMsg_ParticleManager.DestroyParticle _destroy_particle = null;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"destroy_particle", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.DestroyParticle destroy_particle
        {
            get { return _destroy_particle; }
            set { _destroy_particle = value; }
        }
        private CDOTAUserMsg_ParticleManager.DestroyParticleInvolving _destroy_particle_involving = null;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"destroy_particle_involving", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.DestroyParticleInvolving destroy_particle_involving
        {
            get { return _destroy_particle_involving; }
            set { _destroy_particle_involving = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticle _update_particle = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"update_particle", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticle update_particle
        {
            get { return _update_particle; }
            set { _update_particle = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticleFwd _update_particle_fwd = null;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"update_particle_fwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticleFwd update_particle_fwd
        {
            get { return _update_particle_fwd; }
            set { _update_particle_fwd = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticleOrient _update_particle_orient = null;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"update_particle_orient", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticleOrient update_particle_orient
        {
            get { return _update_particle_orient; }
            set { _update_particle_orient = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticleFallback _update_particle_fallback = null;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"update_particle_fallback", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticleFallback update_particle_fallback
        {
            get { return _update_particle_fallback; }
            set { _update_particle_fallback = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticleOffset _update_particle_offset = null;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"update_particle_offset", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticleOffset update_particle_offset
        {
            get { return _update_particle_offset; }
            set { _update_particle_offset = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticleEnt _update_particle_ent = null;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name = @"update_particle_ent", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticleEnt update_particle_ent
        {
            get { return _update_particle_ent; }
            set { _update_particle_ent = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticleShouldDraw _update_particle_should_draw = null;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"update_particle_should_draw", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticleShouldDraw update_particle_should_draw
        {
            get { return _update_particle_should_draw; }
            set { _update_particle_should_draw = value; }
        }
        private CDOTAUserMsg_ParticleManager.UpdateParticleSetFrozen _update_particle_set_frozen = null;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name = @"update_particle_set_frozen", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAUserMsg_ParticleManager.UpdateParticleSetFrozen update_particle_set_frozen
        {
            get { return _update_particle_set_frozen; }
            set { _update_particle_set_frozen = value; }
        }
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"ReleaseParticleIndex")]
        public partial class ReleaseParticleIndex : global::ProtoBuf.IExtensible
        {
            public ReleaseParticleIndex() { }

            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CreateParticle")]
        public partial class CreateParticle : global::ProtoBuf.IExtensible
        {
            public CreateParticle() { }

            private int _particle_name_index = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"particle_name_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int particle_name_index
            {
                get { return _particle_name_index; }
                set { _particle_name_index = value; }
            }
            private int _attach_type = default(int);
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"attach_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int attach_type
            {
                get { return _attach_type; }
                set { _attach_type = value; }
            }
            private int _entity_handle = default(int);
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int entity_handle
            {
                get { return _entity_handle; }
                set { _entity_handle = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"DestroyParticle")]
        public partial class DestroyParticle : global::ProtoBuf.IExtensible
        {
            public DestroyParticle() { }

            private bool _destroy_immediately = default(bool);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"destroy_immediately", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(default(bool))]
            public bool destroy_immediately
            {
                get { return _destroy_immediately; }
                set { _destroy_immediately = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"DestroyParticleInvolving")]
        public partial class DestroyParticleInvolving : global::ProtoBuf.IExtensible
        {
            public DestroyParticleInvolving() { }

            private bool _destroy_immediately = default(bool);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"destroy_immediately", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(default(bool))]
            public bool destroy_immediately
            {
                get { return _destroy_immediately; }
                set { _destroy_immediately = value; }
            }
            private int _entity_handle = default(int);
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int entity_handle
            {
                get { return _entity_handle; }
                set { _entity_handle = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticle")]
        public partial class UpdateParticle : global::ProtoBuf.IExtensible
        {
            public UpdateParticle() { }

            private int _control_point = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int control_point
            {
                get { return _control_point; }
                set { _control_point = value; }
            }
            private CMsgVector _position = null;
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector position
            {
                get { return _position; }
                set { _position = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticleFwd")]
        public partial class UpdateParticleFwd : global::ProtoBuf.IExtensible
        {
            public UpdateParticleFwd() { }

            private int _control_point = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int control_point
            {
                get { return _control_point; }
                set { _control_point = value; }
            }
            private CMsgVector _forward = null;
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"forward", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector forward
            {
                get { return _forward; }
                set { _forward = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticleOrient")]
        public partial class UpdateParticleOrient : global::ProtoBuf.IExtensible
        {
            public UpdateParticleOrient() { }

            private int _control_point = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int control_point
            {
                get { return _control_point; }
                set { _control_point = value; }
            }
            private CMsgVector _forward = null;
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"forward", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector forward
            {
                get { return _forward; }
                set { _forward = value; }
            }
            private CMsgVector _right = null;
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"right", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector right
            {
                get { return _right; }
                set { _right = value; }
            }
            private CMsgVector _up = null;
            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"up", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector up
            {
                get { return _up; }
                set { _up = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticleFallback")]
        public partial class UpdateParticleFallback : global::ProtoBuf.IExtensible
        {
            public UpdateParticleFallback() { }

            private int _control_point = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int control_point
            {
                get { return _control_point; }
                set { _control_point = value; }
            }
            private CMsgVector _position = null;
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector position
            {
                get { return _position; }
                set { _position = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticleOffset")]
        public partial class UpdateParticleOffset : global::ProtoBuf.IExtensible
        {
            public UpdateParticleOffset() { }

            private int _control_point = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int control_point
            {
                get { return _control_point; }
                set { _control_point = value; }
            }
            private CMsgVector _origin_offset = null;
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"origin_offset", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector origin_offset
            {
                get { return _origin_offset; }
                set { _origin_offset = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticleEnt")]
        public partial class UpdateParticleEnt : global::ProtoBuf.IExtensible
        {
            public UpdateParticleEnt() { }

            private int _control_point = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"control_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int control_point
            {
                get { return _control_point; }
                set { _control_point = value; }
            }
            private int _entity_handle = default(int);
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"entity_handle", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int entity_handle
            {
                get { return _entity_handle; }
                set { _entity_handle = value; }
            }
            private int _attach_type = default(int);
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"attach_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int attach_type
            {
                get { return _attach_type; }
                set { _attach_type = value; }
            }
            private int _attachment = default(int);
            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"attachment", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int attachment
            {
                get { return _attachment; }
                set { _attachment = value; }
            }
            private CMsgVector _fallback_position = null;
            [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"fallback_position", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CMsgVector fallback_position
            {
                get { return _fallback_position; }
                set { _fallback_position = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticleSetFrozen")]
        public partial class UpdateParticleSetFrozen : global::ProtoBuf.IExtensible
        {
            public UpdateParticleSetFrozen() { }

            private bool _set_frozen = default(bool);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"set_frozen", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(default(bool))]
            public bool set_frozen
            {
                get { return _set_frozen; }
                set { _set_frozen = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"UpdateParticleShouldDraw")]
        public partial class UpdateParticleShouldDraw : global::ProtoBuf.IExtensible
        {
            public UpdateParticleShouldDraw() { }

            private bool _should_draw = default(bool);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"should_draw", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(default(bool))]
            public bool should_draw
            {
                get { return _should_draw; }
                set { _should_draw = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_OverheadEvent")]
    public partial class CDOTAUserMsg_OverheadEvent : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_OverheadEvent() { }

        private DOTA_OVERHEAD_ALERT _message_type;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"message_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public DOTA_OVERHEAD_ALERT message_type
        {
            get { return _message_type; }
            set { _message_type = value; }
        }
        private int _value = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int value
        {
            get { return _value; }
            set { _value = value; }
        }
        private int _target_player_entindex = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"target_player_entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int target_player_entindex
        {
            get { return _target_player_entindex; }
            set { _target_player_entindex = value; }
        }
        private int _target_entindex = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"target_entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int target_entindex
        {
            get { return _target_entindex; }
            set { _target_entindex = value; }
        }
        private int _source_player_entindex = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"source_player_entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int source_player_entindex
        {
            get { return _source_player_entindex; }
            set { _source_player_entindex = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_TutorialTipInfo")]
    public partial class CDOTAUserMsg_TutorialTipInfo : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_TutorialTipInfo() { }

        private string _name = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _progress = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int progress
        {
            get { return _progress; }
            set { _progress = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_TutorialFinish")]
    public partial class CDOTAUserMsg_TutorialFinish : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_TutorialFinish() { }

        private string _heading = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"heading", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string heading
        {
            get { return _heading; }
            set { _heading = value; }
        }
        private string _emblem = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"emblem", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string emblem
        {
            get { return _emblem; }
            set { _emblem = value; }
        }
        private string _body = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"body", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string body
        {
            get { return _body; }
            set { _body = value; }
        }
        private bool _success = default(bool);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool success
        {
            get { return _success; }
            set { _success = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SendGenericToolTip")]
    public partial class CDOTAUserMsg_SendGenericToolTip : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SendGenericToolTip() { }

        private string _title = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _text = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        private int _entindex = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"entindex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entindex
        {
            get { return _entindex; }
            set { _entindex = value; }
        }
        private bool _close = default(bool);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"close", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool close
        {
            get { return _close; }
            set { _close = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_WorldLine")]
    public partial class CDOTAUserMsg_WorldLine : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_WorldLine() { }

        private int _player_id = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private CDOTAMsg_WorldLine _worldline = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"worldline", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAMsg_WorldLine worldline
        {
            get { return _worldline; }
            set { _worldline = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_TournamentDrop")]
    public partial class CDOTAUserMsg_TournamentDrop : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_TournamentDrop() { }

        private string _winner_name = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"winner_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string winner_name
        {
            get { return _winner_name; }
            set { _winner_name = value; }
        }
        private int _event_type = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"event_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int event_type
        {
            get { return _event_type; }
            set { _event_type = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ChatWheel")]
    public partial class CDOTAUserMsg_ChatWheel : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ChatWheel() { }

        private EDOTAChatWheelMessage _chat_message = EDOTAChatWheelMessage.k_EDOTA_CW_Ok;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"chat_message", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(EDOTAChatWheelMessage.k_EDOTA_CW_Ok)]
        public EDOTAChatWheelMessage chat_message
        {
            get { return _chat_message; }
            set { _chat_message = value; }
        }
        private uint _player_id = default(uint);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private uint _account_id = default(uint);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"account_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint account_id
        {
            get { return _account_id; }
            set { _account_id = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ReceivedXmasGift")]
    public partial class CDOTAUserMsg_ReceivedXmasGift : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ReceivedXmasGift() { }

        private int _player_id = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private string _item_name = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"item_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string item_name
        {
            get { return _item_name; }
            set { _item_name = value; }
        }
        private int _inventory_slot = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"inventory_slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int inventory_slot
        {
            get { return _inventory_slot; }
            set { _inventory_slot = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_ShowSurvey")]
    public partial class CDOTAUserMsg_ShowSurvey : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_ShowSurvey() { }

        private int _survey_id = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"survey_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int survey_id
        {
            get { return _survey_id; }
            set { _survey_id = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_UpdateSharedContent")]
    public partial class CDOTAUserMsg_UpdateSharedContent : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_UpdateSharedContent() { }

        private int _slot_type = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"slot_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int slot_type
        {
            get { return _slot_type; }
            set { _slot_type = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_TutorialRequestExp")]
    public partial class CDOTAUserMsg_TutorialRequestExp : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_TutorialRequestExp() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_TutorialFade")]
    public partial class CDOTAUserMsg_TutorialFade : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_TutorialFade() { }

        private int _tgt_alpha = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"tgt_alpha", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int tgt_alpha
        {
            get { return _tgt_alpha; }
            set { _tgt_alpha = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_TutorialPingMinimap")]
    public partial class CDOTAUserMsg_TutorialPingMinimap : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_TutorialPingMinimap() { }

        private uint _player_id = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private float _pos_x = default(float);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"pos_x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float pos_x
        {
            get { return _pos_x; }
            set { _pos_x = value; }
        }
        private float _pos_y = default(float);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"pos_y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float pos_y
        {
            get { return _pos_y; }
            set { _pos_y = value; }
        }
        private float _pos_z = default(float);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"pos_z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float pos_z
        {
            get { return _pos_z; }
            set { _pos_z = value; }
        }
        private int _entity_index = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"entity_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entity_index
        {
            get { return _entity_index; }
            set { _entity_index = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTA_UM_GamerulesStateChanged")]
    public partial class CDOTA_UM_GamerulesStateChanged : global::ProtoBuf.IExtensible
    {
        public CDOTA_UM_GamerulesStateChanged() { }

        private uint _state = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint state
        {
            get { return _state; }
            set { _state = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_AddQuestLogEntry")]
    public partial class CDOTAUserMsg_AddQuestLogEntry : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_AddQuestLogEntry() { }

        private string _npc_name = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"npc_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string npc_name
        {
            get { return _npc_name; }
            set { _npc_name = value; }
        }
        private string _npc_dialog = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"npc_dialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string npc_dialog
        {
            get { return _npc_dialog; }
            set { _npc_dialog = value; }
        }
        private bool _quest = default(bool);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"quest", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool quest
        {
            get { return _quest; }
            set { _quest = value; }
        }
        private int _quest_type = default(int);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"quest_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int quest_type
        {
            get { return _quest_type; }
            set { _quest_type = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SendStatPopup")]
    public partial class CDOTAUserMsg_SendStatPopup : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SendStatPopup() { }

        private int _player_id = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player_id
        {
            get { return _player_id; }
            set { _player_id = value; }
        }
        private CDOTAMsg_SendStatPopup _statpopup = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"statpopup", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDOTAMsg_SendStatPopup statpopup
        {
            get { return _statpopup; }
            set { _statpopup = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SendRoshanPopup")]
    public partial class CDOTAUserMsg_SendRoshanPopup : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SendRoshanPopup() { }

        private bool _reclaimed = default(bool);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"reclaimed", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool reclaimed
        {
            get { return _reclaimed; }
            set { _reclaimed = value; }
        }
        private int _gametime = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"gametime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int gametime
        {
            get { return _gametime; }
            set { _gametime = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAUserMsg_SendFinalGold")]
    public partial class CDOTAUserMsg_SendFinalGold : global::ProtoBuf.IExtensible
    {
        public CDOTAUserMsg_SendFinalGold() { }

        private readonly global::System.Collections.Generic.List<uint> _reliable_gold = new global::System.Collections.Generic.List<uint>();
        [global::ProtoBuf.ProtoMember(1, Name = @"reliable_gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<uint> reliable_gold
        {
            get { return _reliable_gold; }
        }

        private readonly global::System.Collections.Generic.List<uint> _unreliable_gold = new global::System.Collections.Generic.List<uint>();
        [global::ProtoBuf.ProtoMember(2, Name = @"unreliable_gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<uint> unreliable_gold
        {
            get { return _unreliable_gold; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_AchievementEvent")]
    public partial class CUserMsg_AchievementEvent : global::ProtoBuf.IExtensible
    {
        public CUserMsg_AchievementEvent() { }

        private uint _achievement = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"achievement", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint achievement
        {
            get { return _achievement; }
            set { _achievement = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_CloseCaption")]
    public partial class CUserMsg_CloseCaption : global::ProtoBuf.IExtensible
    {
        public CUserMsg_CloseCaption() { }

        private uint _hash = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"hash", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint hash
        {
            get { return _hash; }
            set { _hash = value; }
        }
        private float _duration = default(float);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private bool _from_player = default(bool);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"from_player", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool from_player
        {
            get { return _from_player; }
            set { _from_player = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_CurrentTimescale")]
    public partial class CUserMsg_CurrentTimescale : global::ProtoBuf.IExtensible
    {
        public CUserMsg_CurrentTimescale() { }

        private float _current = default(float);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"current", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float current
        {
            get { return _current; }
            set { _current = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_DesiredTimescale")]
    public partial class CUserMsg_DesiredTimescale : global::ProtoBuf.IExtensible
    {
        public CUserMsg_DesiredTimescale() { }

        private float _desired = default(float);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"desired", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float desired
        {
            get { return _desired; }
            set { _desired = value; }
        }
        private float _duration = default(float);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private uint _interpolator = default(uint);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"interpolator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint interpolator
        {
            get { return _interpolator; }
            set { _interpolator = value; }
        }
        private float _start_blend_time = default(float);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"start_blend_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float start_blend_time
        {
            get { return _start_blend_time; }
            set { _start_blend_time = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_Fade")]
    public partial class CUserMsg_Fade : global::ProtoBuf.IExtensible
    {
        public CUserMsg_Fade() { }

        private uint _duration = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private uint _hold_time = default(uint);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"hold_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint hold_time
        {
            get { return _hold_time; }
            set { _hold_time = value; }
        }
        private uint _flags = default(uint);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint flags
        {
            get { return _flags; }
            set { _flags = value; }
        }
        private uint _color = default(uint);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"color", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint color
        {
            get { return _color; }
            set { _color = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_Shake")]
    public partial class CUserMsg_Shake : global::ProtoBuf.IExtensible
    {
        public CUserMsg_Shake() { }

        private uint _command = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint command
        {
            get { return _command; }
            set { _command = value; }
        }
        private float _amplitude = default(float);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"amplitude", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float amplitude
        {
            get { return _amplitude; }
            set { _amplitude = value; }
        }
        private float _frequency = default(float);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"frequency", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        private float _duration = default(float);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_ShakeDir")]
    public partial class CUserMsg_ShakeDir : global::ProtoBuf.IExtensible
    {
        public CUserMsg_ShakeDir() { }

        private CUserMsg_Shake _shake = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"shake", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CUserMsg_Shake shake
        {
            get { return _shake; }
            set { _shake = value; }
        }
        private CMsgVector _direction = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"direction", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_Tilt")]
    public partial class CUserMsg_Tilt : global::ProtoBuf.IExtensible
    {
        public CUserMsg_Tilt() { }

        private uint _command = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"command", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint command
        {
            get { return _command; }
            set { _command = value; }
        }
        private bool _ease_in_out = default(bool);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"ease_in_out", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool ease_in_out
        {
            get { return _ease_in_out; }
            set { _ease_in_out = value; }
        }
        private CMsgVector _angle = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"angle", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector angle
        {
            get { return _angle; }
            set { _angle = value; }
        }
        private float _duration = default(float);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private float _time = default(float);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float time
        {
            get { return _time; }
            set { _time = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_SayText")]
    public partial class CUserMsg_SayText : global::ProtoBuf.IExtensible
    {
        public CUserMsg_SayText() { }

        private uint _client = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"client", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint client
        {
            get { return _client; }
            set { _client = value; }
        }
        private string _text = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        private bool _chat = default(bool);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"chat", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool chat
        {
            get { return _chat; }
            set { _chat = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_SayText2")]
    public partial class CUserMsg_SayText2 : global::ProtoBuf.IExtensible
    {
        public CUserMsg_SayText2() { }

        private uint _client = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"client", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint client
        {
            get { return _client; }
            set { _client = value; }
        }
        private bool _chat = default(bool);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"chat", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool chat
        {
            get { return _chat; }
            set { _chat = value; }
        }
        private string _format = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"format", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string format
        {
            get { return _format; }
            set { _format = value; }
        }
        private string _prefix = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"prefix", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }
        private string _text = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        private string _location = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"location", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string location
        {
            get { return _location; }
            set { _location = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_HudMsg")]
    public partial class CUserMsg_HudMsg : global::ProtoBuf.IExtensible
    {
        public CUserMsg_HudMsg() { }

        private uint _channel = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"channel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint channel
        {
            get { return _channel; }
            set { _channel = value; }
        }
        private float _x = default(float);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float x
        {
            get { return _x; }
            set { _x = value; }
        }
        private float _y = default(float);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float y
        {
            get { return _y; }
            set { _y = value; }
        }
        private uint _color1 = default(uint);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"color1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint color1
        {
            get { return _color1; }
            set { _color1 = value; }
        }
        private uint _color2 = default(uint);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"color2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint color2
        {
            get { return _color2; }
            set { _color2 = value; }
        }
        private uint _effect = default(uint);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"effect", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint effect
        {
            get { return _effect; }
            set { _effect = value; }
        }
        private float _fade_in_time = default(float);
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"fade_in_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float fade_in_time
        {
            get { return _fade_in_time; }
            set { _fade_in_time = value; }
        }
        private float _fade_out_time = default(float);
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"fade_out_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float fade_out_time
        {
            get { return _fade_out_time; }
            set { _fade_out_time = value; }
        }
        private float _hold_time = default(float);
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"hold_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float hold_time
        {
            get { return _hold_time; }
            set { _hold_time = value; }
        }
        private float _fx_time = default(float);
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"fx_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float fx_time
        {
            get { return _fx_time; }
            set { _fx_time = value; }
        }
        private string _message = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_HudText")]
    public partial class CUserMsg_HudText : global::ProtoBuf.IExtensible
    {
        public CUserMsg_HudText() { }

        private string _message = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_TextMsg")]
    public partial class CUserMsg_TextMsg : global::ProtoBuf.IExtensible
    {
        public CUserMsg_TextMsg() { }

        private uint _dest = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"dest", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint dest
        {
            get { return _dest; }
            set { _dest = value; }
        }
        private readonly global::System.Collections.Generic.List<string> _param = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(2, Name = @"param", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> param
        {
            get { return _param; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_GameTitle")]
    public partial class CUserMsg_GameTitle : global::ProtoBuf.IExtensible
    {
        public CUserMsg_GameTitle() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_ResetHUD")]
    public partial class CUserMsg_ResetHUD : global::ProtoBuf.IExtensible
    {
        public CUserMsg_ResetHUD() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_SendAudio")]
    public partial class CUserMsg_SendAudio : global::ProtoBuf.IExtensible
    {
        public CUserMsg_SendAudio() { }

        private bool _stop = default(bool);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"stop", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool stop
        {
            get { return _stop; }
            set { _stop = value; }
        }
        private string _name = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_VoiceMask")]
    public partial class CUserMsg_VoiceMask : global::ProtoBuf.IExtensible
    {
        public CUserMsg_VoiceMask() { }

        private readonly global::System.Collections.Generic.List<int> _audible_players_mask = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(1, Name = @"audible_players_mask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> audible_players_mask
        {
            get { return _audible_players_mask; }
        }

        private bool _player_mod_enabled = default(bool);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"player_mod_enabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool player_mod_enabled
        {
            get { return _player_mod_enabled; }
            set { _player_mod_enabled = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_RequestState")]
    public partial class CUserMsg_RequestState : global::ProtoBuf.IExtensible
    {
        public CUserMsg_RequestState() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_HintText")]
    public partial class CUserMsg_HintText : global::ProtoBuf.IExtensible
    {
        public CUserMsg_HintText() { }

        private string _message = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_KeyHintText")]
    public partial class CUserMsg_KeyHintText : global::ProtoBuf.IExtensible
    {
        public CUserMsg_KeyHintText() { }

        private readonly global::System.Collections.Generic.List<string> _messages = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(1, Name = @"messages", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> messages
        {
            get { return _messages; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_StatsCrawlMsg")]
    public partial class CUserMsg_StatsCrawlMsg : global::ProtoBuf.IExtensible
    {
        public CUserMsg_StatsCrawlMsg() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_StatsSkipState")]
    public partial class CUserMsg_StatsSkipState : global::ProtoBuf.IExtensible
    {
        public CUserMsg_StatsSkipState() { }

        private int _num_skips = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"num_skips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int num_skips
        {
            get { return _num_skips; }
            set { _num_skips = value; }
        }
        private int _num_players = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"num_players", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int num_players
        {
            get { return _num_players; }
            set { _num_players = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_VoiceSubtitle")]
    public partial class CUserMsg_VoiceSubtitle : global::ProtoBuf.IExtensible
    {
        public CUserMsg_VoiceSubtitle() { }

        private int _ent_index = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"ent_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int ent_index
        {
            get { return _ent_index; }
            set { _ent_index = value; }
        }
        private int _menu = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"menu", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int menu
        {
            get { return _menu; }
            set { _menu = value; }
        }
        private int _item = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"item", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int item
        {
            get { return _item; }
            set { _item = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_VGUIMenu")]
    public partial class CUserMsg_VGUIMenu : global::ProtoBuf.IExtensible
    {
        public CUserMsg_VGUIMenu() { }

        private string _name = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private bool _show = default(bool);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"show", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool show
        {
            get { return _show; }
            set { _show = value; }
        }
        private readonly global::System.Collections.Generic.List<CUserMsg_VGUIMenu.Keys> _keys = new global::System.Collections.Generic.List<CUserMsg_VGUIMenu.Keys>();
        [global::ProtoBuf.ProtoMember(3, Name = @"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CUserMsg_VGUIMenu.Keys> keys
        {
            get { return _keys; }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"Keys")]
        public partial class Keys : global::ProtoBuf.IExtensible
        {
            public Keys() { }

            private string _name = "";
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            private string _value = "";
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string value
            {
                get { return _value; }
                set { _value = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_Geiger")]
    public partial class CUserMsg_Geiger : global::ProtoBuf.IExtensible
    {
        public CUserMsg_Geiger() { }

        private int _range = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"range", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int range
        {
            get { return _range; }
            set { _range = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_Rumble")]
    public partial class CUserMsg_Rumble : global::ProtoBuf.IExtensible
    {
        public CUserMsg_Rumble() { }

        private int _index = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int index
        {
            get { return _index; }
            set { _index = value; }
        }
        private int _data = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"data", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int data
        {
            get { return _data; }
            set { _data = value; }
        }
        private int _flags = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int flags
        {
            get { return _flags; }
            set { _flags = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_Train")]
    public partial class CUserMsg_Train : global::ProtoBuf.IExtensible
    {
        public CUserMsg_Train() { }

        private int _train = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"train", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int train
        {
            get { return _train; }
            set { _train = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_SayTextChannel")]
    public partial class CUserMsg_SayTextChannel : global::ProtoBuf.IExtensible
    {
        public CUserMsg_SayTextChannel() { }

        private int _player = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"player", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player
        {
            get { return _player; }
            set { _player = value; }
        }
        private int _channel = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"channel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int channel
        {
            get { return _channel; }
            set { _channel = value; }
        }
        private string _text = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CUserMsg_MessageText")]
    public partial class CUserMsg_MessageText : global::ProtoBuf.IExtensible
    {
        public CUserMsg_MessageText() { }

        private uint _color = default(uint);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint color
        {
            get { return _color; }
            set { _color = value; }
        }
        private string _text = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAMsg_LocationPing")]
    public partial class CDOTAMsg_LocationPing : global::ProtoBuf.IExtensible
    {
        public CDOTAMsg_LocationPing() { }

        private int _x = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        private int _target = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"target", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int target
        {
            get { return _target; }
            set { _target = value; }
        }
        private bool _direct_ping = default(bool);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"direct_ping", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool direct_ping
        {
            get { return _direct_ping; }
            set { _direct_ping = value; }
        }
        private int _type = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int type
        {
            get { return _type; }
            set { _type = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAMsg_ItemAlert")]
    public partial class CDOTAMsg_ItemAlert : global::ProtoBuf.IExtensible
    {
        public CDOTAMsg_ItemAlert() { }

        private int _x = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        private int _itemid = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAMsg_MapLine")]
    public partial class CDOTAMsg_MapLine : global::ProtoBuf.IExtensible
    {
        public CDOTAMsg_MapLine() { }

        private int _x = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        private bool _initial = default(bool);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"initial", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool initial
        {
            get { return _initial; }
            set { _initial = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAMsg_WorldLine")]
    public partial class CDOTAMsg_WorldLine : global::ProtoBuf.IExtensible
    {
        public CDOTAMsg_WorldLine() { }

        private int _x = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        private int _z = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int z
        {
            get { return _z; }
            set { _z = value; }
        }
        private bool _initial = default(bool);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"initial", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool initial
        {
            get { return _initial; }
            set { _initial = value; }
        }
        private bool _end = default(bool);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"end", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool end
        {
            get { return _end; }
            set { _end = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAMsg_SendStatPopup")]
    public partial class CDOTAMsg_SendStatPopup : global::ProtoBuf.IExtensible
    {
        public CDOTAMsg_SendStatPopup() { }

        private EDOTAStatPopupTypes _style = EDOTAStatPopupTypes.k_EDOTA_SPT_Textline;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"style", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(EDOTAStatPopupTypes.k_EDOTA_SPT_Textline)]
        public EDOTAStatPopupTypes style
        {
            get { return _style; }
            set { _style = value; }
        }
        private readonly global::System.Collections.Generic.List<string> _stat_strings = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(2, Name = @"stat_strings", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> stat_strings
        {
            get { return _stat_strings; }
        }

        private readonly global::System.Collections.Generic.List<int> _stat_images = new global::System.Collections.Generic.List<int>();
        [global::ProtoBuf.ProtoMember(3, Name = @"stat_images", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public global::System.Collections.Generic.List<int> stat_images
        {
            get { return _stat_images; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"EDotaUserMessages")]
    public enum EDotaUserMessages
    {

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_AddUnitToSelection", Value = 64)]
        DOTA_UM_AddUnitToSelection = 64,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_AIDebugLine", Value = 65)]
        DOTA_UM_AIDebugLine = 65,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ChatEvent", Value = 66)]
        DOTA_UM_ChatEvent = 66,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_CombatHeroPositions", Value = 67)]
        DOTA_UM_CombatHeroPositions = 67,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_CombatLogData", Value = 68)]
        DOTA_UM_CombatLogData = 68,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_CombatLogShowDeath", Value = 70)]
        DOTA_UM_CombatLogShowDeath = 70,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_CreateLinearProjectile", Value = 71)]
        DOTA_UM_CreateLinearProjectile = 71,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_DestroyLinearProjectile", Value = 72)]
        DOTA_UM_DestroyLinearProjectile = 72,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_DodgeTrackingProjectiles", Value = 73)]
        DOTA_UM_DodgeTrackingProjectiles = 73,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_GlobalLightColor", Value = 74)]
        DOTA_UM_GlobalLightColor = 74,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_GlobalLightDirection", Value = 75)]
        DOTA_UM_GlobalLightDirection = 75,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_InvalidCommand", Value = 76)]
        DOTA_UM_InvalidCommand = 76,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_LocationPing", Value = 77)]
        DOTA_UM_LocationPing = 77,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_MapLine", Value = 78)]
        DOTA_UM_MapLine = 78,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_MiniKillCamInfo", Value = 79)]
        DOTA_UM_MiniKillCamInfo = 79,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_MinimapDebugPoint", Value = 80)]
        DOTA_UM_MinimapDebugPoint = 80,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_MinimapEvent", Value = 81)]
        DOTA_UM_MinimapEvent = 81,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_NevermoreRequiem", Value = 82)]
        DOTA_UM_NevermoreRequiem = 82,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_OverheadEvent", Value = 83)]
        DOTA_UM_OverheadEvent = 83,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SetNextAutobuyItem", Value = 84)]
        DOTA_UM_SetNextAutobuyItem = 84,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SharedCooldown", Value = 85)]
        DOTA_UM_SharedCooldown = 85,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SpectatorPlayerClick", Value = 86)]
        DOTA_UM_SpectatorPlayerClick = 86,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_TutorialTipInfo", Value = 87)]
        DOTA_UM_TutorialTipInfo = 87,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_UnitEvent", Value = 88)]
        DOTA_UM_UnitEvent = 88,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ParticleManager", Value = 89)]
        DOTA_UM_ParticleManager = 89,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_BotChat", Value = 90)]
        DOTA_UM_BotChat = 90,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_HudError", Value = 91)]
        DOTA_UM_HudError = 91,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ItemPurchased", Value = 92)]
        DOTA_UM_ItemPurchased = 92,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_Ping", Value = 93)]
        DOTA_UM_Ping = 93,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ItemFound", Value = 94)]
        DOTA_UM_ItemFound = 94,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_CharacterSpeakConcept", Value = 95)]
        DOTA_UM_CharacterSpeakConcept = 95,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SwapVerify", Value = 96)]
        DOTA_UM_SwapVerify = 96,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_WorldLine", Value = 97)]
        DOTA_UM_WorldLine = 97,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_TournamentDrop", Value = 98)]
        DOTA_UM_TournamentDrop = 98,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ItemAlert", Value = 99)]
        DOTA_UM_ItemAlert = 99,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_HalloweenDrops", Value = 100)]
        DOTA_UM_HalloweenDrops = 100,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ChatWheel", Value = 101)]
        DOTA_UM_ChatWheel = 101,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ReceivedXmasGift", Value = 102)]
        DOTA_UM_ReceivedXmasGift = 102,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_UpdateSharedContent", Value = 103)]
        DOTA_UM_UpdateSharedContent = 103,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_TutorialRequestExp", Value = 104)]
        DOTA_UM_TutorialRequestExp = 104,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_TutorialPingMinimap", Value = 105)]
        DOTA_UM_TutorialPingMinimap = 105,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_GamerulesStateChanged", Value = 106)]
        DOTA_UM_GamerulesStateChanged = 106,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_ShowSurvey", Value = 107)]
        DOTA_UM_ShowSurvey = 107,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_TutorialFade", Value = 108)]
        DOTA_UM_TutorialFade = 108,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_AddQuestLogEntry", Value = 109)]
        DOTA_UM_AddQuestLogEntry = 109,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SendStatPopup", Value = 110)]
        DOTA_UM_SendStatPopup = 110,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_TutorialFinish", Value = 111)]
        DOTA_UM_TutorialFinish = 111,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SendRoshanPopup", Value = 112)]
        DOTA_UM_SendRoshanPopup = 112,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SendGenericToolTip", Value = 113)]
        DOTA_UM_SendGenericToolTip = 113,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UM_SendFinalGold", Value = 114)]
        DOTA_UM_SendFinalGold = 114
    }

    [global::ProtoBuf.ProtoContract(Name = @"DOTA_CHAT_MESSAGE")]
    public enum DOTA_CHAT_MESSAGE
    {

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_INVALID", Value = -1)]
        CHAT_MESSAGE_INVALID = -1,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_HERO_KILL", Value = 0)]
        CHAT_MESSAGE_HERO_KILL = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_HERO_DENY", Value = 1)]
        CHAT_MESSAGE_HERO_DENY = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_BARRACKS_KILL", Value = 2)]
        CHAT_MESSAGE_BARRACKS_KILL = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_TOWER_KILL", Value = 3)]
        CHAT_MESSAGE_TOWER_KILL = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_TOWER_DENY", Value = 4)]
        CHAT_MESSAGE_TOWER_DENY = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_FIRSTBLOOD", Value = 5)]
        CHAT_MESSAGE_FIRSTBLOOD = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_STREAK_KILL", Value = 6)]
        CHAT_MESSAGE_STREAK_KILL = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_BUYBACK", Value = 7)]
        CHAT_MESSAGE_BUYBACK = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_AEGIS", Value = 8)]
        CHAT_MESSAGE_AEGIS = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ROSHAN_KILL", Value = 9)]
        CHAT_MESSAGE_ROSHAN_KILL = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_COURIER_LOST", Value = 10)]
        CHAT_MESSAGE_COURIER_LOST = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_COURIER_RESPAWNED", Value = 11)]
        CHAT_MESSAGE_COURIER_RESPAWNED = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_GLYPH_USED", Value = 12)]
        CHAT_MESSAGE_GLYPH_USED = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ITEM_PURCHASE", Value = 13)]
        CHAT_MESSAGE_ITEM_PURCHASE = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_CONNECT", Value = 14)]
        CHAT_MESSAGE_CONNECT = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_DISCONNECT", Value = 15)]
        CHAT_MESSAGE_DISCONNECT = 15,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_DISCONNECT_WAIT_FOR_RECONNECT", Value = 16)]
        CHAT_MESSAGE_DISCONNECT_WAIT_FOR_RECONNECT = 16,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_DISCONNECT_TIME_REMAINING", Value = 17)]
        CHAT_MESSAGE_DISCONNECT_TIME_REMAINING = 17,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_DISCONNECT_TIME_REMAINING_PLURAL", Value = 18)]
        CHAT_MESSAGE_DISCONNECT_TIME_REMAINING_PLURAL = 18,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_RECONNECT", Value = 19)]
        CHAT_MESSAGE_RECONNECT = 19,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ABANDON", Value = 20)]
        CHAT_MESSAGE_ABANDON = 20,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_SAFE_TO_LEAVE", Value = 21)]
        CHAT_MESSAGE_SAFE_TO_LEAVE = 21,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_RUNE_PICKUP", Value = 22)]
        CHAT_MESSAGE_RUNE_PICKUP = 22,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_RUNE_BOTTLE", Value = 23)]
        CHAT_MESSAGE_RUNE_BOTTLE = 23,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_INTHEBAG", Value = 24)]
        CHAT_MESSAGE_INTHEBAG = 24,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_SECRETSHOP", Value = 25)]
        CHAT_MESSAGE_SECRETSHOP = 25,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ITEM_AUTOPURCHASED", Value = 26)]
        CHAT_MESSAGE_ITEM_AUTOPURCHASED = 26,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ITEMS_COMBINED", Value = 27)]
        CHAT_MESSAGE_ITEMS_COMBINED = 27,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_SUPER_CREEPS", Value = 28)]
        CHAT_MESSAGE_SUPER_CREEPS = 28,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_CANT_USE_ACTION_ITEM", Value = 29)]
        CHAT_MESSAGE_CANT_USE_ACTION_ITEM = 29,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_CHARGES_EXHAUSTED", Value = 30)]
        CHAT_MESSAGE_CHARGES_EXHAUSTED = 30,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_CANTPAUSE", Value = 31)]
        CHAT_MESSAGE_CANTPAUSE = 31,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_NOPAUSESLEFT", Value = 32)]
        CHAT_MESSAGE_NOPAUSESLEFT = 32,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_CANTPAUSEYET", Value = 33)]
        CHAT_MESSAGE_CANTPAUSEYET = 33,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_PAUSED", Value = 34)]
        CHAT_MESSAGE_PAUSED = 34,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_UNPAUSE_COUNTDOWN", Value = 35)]
        CHAT_MESSAGE_UNPAUSE_COUNTDOWN = 35,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_UNPAUSED", Value = 36)]
        CHAT_MESSAGE_UNPAUSED = 36,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_AUTO_UNPAUSED", Value = 37)]
        CHAT_MESSAGE_AUTO_UNPAUSED = 37,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_YOUPAUSED", Value = 38)]
        CHAT_MESSAGE_YOUPAUSED = 38,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_CANTUNPAUSETEAM", Value = 39)]
        CHAT_MESSAGE_CANTUNPAUSETEAM = 39,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_SAFE_TO_LEAVE_ABANDONER", Value = 40)]
        CHAT_MESSAGE_SAFE_TO_LEAVE_ABANDONER = 40,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_VOICE_TEXT_BANNED", Value = 41)]
        CHAT_MESSAGE_VOICE_TEXT_BANNED = 41,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_SPECTATORS_WATCHING_THIS_GAME", Value = 42)]
        CHAT_MESSAGE_SPECTATORS_WATCHING_THIS_GAME = 42,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_REPORT_REMINDER", Value = 43)]
        CHAT_MESSAGE_REPORT_REMINDER = 43,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ECON_ITEM", Value = 44)]
        CHAT_MESSAGE_ECON_ITEM = 44,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_TAUNT", Value = 45)]
        CHAT_MESSAGE_TAUNT = 45,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_RANDOM", Value = 46)]
        CHAT_MESSAGE_RANDOM = 46,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_RD_TURN", Value = 47)]
        CHAT_MESSAGE_RD_TURN = 47,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_SAFE_TO_LEAVE_ABANDONER_EARLY", Value = 48)]
        CHAT_MESSAGE_SAFE_TO_LEAVE_ABANDONER_EARLY = 48,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_DROP_RATE_BONUS", Value = 49)]
        CHAT_MESSAGE_DROP_RATE_BONUS = 49,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_NO_BATTLE_POINTS", Value = 50)]
        CHAT_MESSAGE_NO_BATTLE_POINTS = 50,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_DENIED_AEGIS", Value = 51)]
        CHAT_MESSAGE_DENIED_AEGIS = 51,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_INFORMATIONAL", Value = 52)]
        CHAT_MESSAGE_INFORMATIONAL = 52,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_AEGIS_STOLEN", Value = 53)]
        CHAT_MESSAGE_AEGIS_STOLEN = 53,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ROSHAN_CANDY", Value = 54)]
        CHAT_MESSAGE_ROSHAN_CANDY = 54,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_ITEM_GIFTED", Value = 55)]
        CHAT_MESSAGE_ITEM_GIFTED = 55,

        [global::ProtoBuf.ProtoEnum(Name = @"CHAT_MESSAGE_HERO_KILL_WITH_GREEVIL", Value = 56)]
        CHAT_MESSAGE_HERO_KILL_WITH_GREEVIL = 56
    }

    [global::ProtoBuf.ProtoContract(Name = @"DOTA_NO_BATTLE_POINTS_REASONS")]
    public enum DOTA_NO_BATTLE_POINTS_REASONS
    {

        [global::ProtoBuf.ProtoEnum(Name = @"NO_BATTLE_POINTS_WRONG_LOBBY_TYPE", Value = 1)]
        NO_BATTLE_POINTS_WRONG_LOBBY_TYPE = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"NO_BATTLE_POINTS_PRACTICE_BOTS", Value = 2)]
        NO_BATTLE_POINTS_PRACTICE_BOTS = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"NO_BATTLE_POINTS_CHEATS_ENABLED", Value = 3)]
        NO_BATTLE_POINTS_CHEATS_ENABLED = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"NO_BATTLE_POINTS_LOW_PRIORITY", Value = 4)]
        NO_BATTLE_POINTS_LOW_PRIORITY = 4
    }

    [global::ProtoBuf.ProtoContract(Name = @"DOTA_CHAT_INFORMATIONAL")]
    public enum DOTA_CHAT_INFORMATIONAL
    {

        [global::ProtoBuf.ProtoEnum(Name = @"COOP_BATTLE_POINTS_RULES", Value = 1)]
        COOP_BATTLE_POINTS_RULES = 1
    }

    [global::ProtoBuf.ProtoContract(Name = @"DOTA_COMBATLOG_TYPES")]
    public enum DOTA_COMBATLOG_TYPES
    {

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_COMBATLOG_DAMAGE", Value = 0)]
        DOTA_COMBATLOG_DAMAGE = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_COMBATLOG_HEAL", Value = 1)]
        DOTA_COMBATLOG_HEAL = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_COMBATLOG_MODIFIER_ADD", Value = 2)]
        DOTA_COMBATLOG_MODIFIER_ADD = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_COMBATLOG_MODIFIER_REMOVE", Value = 3)]
        DOTA_COMBATLOG_MODIFIER_REMOVE = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_COMBATLOG_DEATH", Value = 4)]
        DOTA_COMBATLOG_DEATH = 4
    }

    [global::ProtoBuf.ProtoContract(Name = @"EDotaEntityMessages")]
    public enum EDotaEntityMessages
    {

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UNIT_SPEECH", Value = 0)]
        DOTA_UNIT_SPEECH = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UNIT_SPEECH_MUTE", Value = 1)]
        DOTA_UNIT_SPEECH_MUTE = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UNIT_ADD_GESTURE", Value = 2)]
        DOTA_UNIT_ADD_GESTURE = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UNIT_REMOVE_GESTURE", Value = 3)]
        DOTA_UNIT_REMOVE_GESTURE = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UNIT_REMOVE_ALL_GESTURES", Value = 4)]
        DOTA_UNIT_REMOVE_ALL_GESTURES = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UNIT_FADE_GESTURE", Value = 6)]
        DOTA_UNIT_FADE_GESTURE = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_UNIT_SPEECH_CLIENTSIDE_RULES", Value = 7)]
        DOTA_UNIT_SPEECH_CLIENTSIDE_RULES = 7
    }

    [global::ProtoBuf.ProtoContract(Name = @"DOTA_PARTICLE_MESSAGE")]
    public enum DOTA_PARTICLE_MESSAGE
    {

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_CREATE", Value = 0)]
        DOTA_PARTICLE_MANAGER_EVENT_CREATE = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_UPDATE", Value = 1)]
        DOTA_PARTICLE_MANAGER_EVENT_UPDATE = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD", Value = 2)]
        DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FORWARD = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION", Value = 3)]
        DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ORIENTATION = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK", Value = 4)]
        DOTA_PARTICLE_MANAGER_EVENT_UPDATE_FALLBACK = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ENT", Value = 5)]
        DOTA_PARTICLE_MANAGER_EVENT_UPDATE_ENT = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET", Value = 6)]
        DOTA_PARTICLE_MANAGER_EVENT_UPDATE_OFFSET = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_DESTROY", Value = 7)]
        DOTA_PARTICLE_MANAGER_EVENT_DESTROY = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING", Value = 8)]
        DOTA_PARTICLE_MANAGER_EVENT_DESTROY_INVOLVING = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_RELEASE", Value = 9)]
        DOTA_PARTICLE_MANAGER_EVENT_RELEASE = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_LATENCY", Value = 10)]
        DOTA_PARTICLE_MANAGER_EVENT_LATENCY = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_SHOULD_DRAW", Value = 11)]
        DOTA_PARTICLE_MANAGER_EVENT_SHOULD_DRAW = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_PARTICLE_MANAGER_EVENT_FROZEN", Value = 12)]
        DOTA_PARTICLE_MANAGER_EVENT_FROZEN = 12
    }

    [global::ProtoBuf.ProtoContract(Name = @"DOTA_OVERHEAD_ALERT")]
    public enum DOTA_OVERHEAD_ALERT
    {

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_GOLD", Value = 0)]
        OVERHEAD_ALERT_GOLD = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_DENY", Value = 1)]
        OVERHEAD_ALERT_DENY = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_CRITICAL", Value = 2)]
        OVERHEAD_ALERT_CRITICAL = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_XP", Value = 3)]
        OVERHEAD_ALERT_XP = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_BONUS_SPELL_DAMAGE", Value = 4)]
        OVERHEAD_ALERT_BONUS_SPELL_DAMAGE = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_MISS", Value = 5)]
        OVERHEAD_ALERT_MISS = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_DAMAGE", Value = 6)]
        OVERHEAD_ALERT_DAMAGE = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_EVADE", Value = 7)]
        OVERHEAD_ALERT_EVADE = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_BLOCK", Value = 8)]
        OVERHEAD_ALERT_BLOCK = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_BONUS_POISON_DAMAGE", Value = 9)]
        OVERHEAD_ALERT_BONUS_POISON_DAMAGE = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_HEAL", Value = 10)]
        OVERHEAD_ALERT_HEAL = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_MANA_ADD", Value = 11)]
        OVERHEAD_ALERT_MANA_ADD = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_MANA_LOSS", Value = 12)]
        OVERHEAD_ALERT_MANA_LOSS = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_LAST_HIT_EARLY", Value = 13)]
        OVERHEAD_ALERT_LAST_HIT_EARLY = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_LAST_HIT_CLOSE", Value = 14)]
        OVERHEAD_ALERT_LAST_HIT_CLOSE = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"OVERHEAD_ALERT_LAST_HIT_MISS", Value = 15)]
        OVERHEAD_ALERT_LAST_HIT_MISS = 15
    }

    [global::ProtoBuf.ProtoContract(Name = @"EBaseUserMessages")]
    public enum EBaseUserMessages
    {

        [global::ProtoBuf.ProtoEnum(Name = @"UM_AchievementEvent", Value = 1)]
        UM_AchievementEvent = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_CloseCaption", Value = 2)]
        UM_CloseCaption = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_CloseCaptionDirect", Value = 3)]
        UM_CloseCaptionDirect = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_CurrentTimescale", Value = 4)]
        UM_CurrentTimescale = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_DesiredTimescale", Value = 5)]
        UM_DesiredTimescale = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_Fade", Value = 6)]
        UM_Fade = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_GameTitle", Value = 7)]
        UM_GameTitle = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_Geiger", Value = 8)]
        UM_Geiger = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_HintText", Value = 9)]
        UM_HintText = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_HudMsg", Value = 10)]
        UM_HudMsg = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_HudText", Value = 11)]
        UM_HudText = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_KeyHintText", Value = 12)]
        UM_KeyHintText = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_MessageText", Value = 13)]
        UM_MessageText = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_RequestState", Value = 14)]
        UM_RequestState = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_ResetHUD", Value = 15)]
        UM_ResetHUD = 15,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_Rumble", Value = 16)]
        UM_Rumble = 16,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_SayText", Value = 17)]
        UM_SayText = 17,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_SayText2", Value = 18)]
        UM_SayText2 = 18,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_SayTextChannel", Value = 19)]
        UM_SayTextChannel = 19,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_Shake", Value = 20)]
        UM_Shake = 20,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_ShakeDir", Value = 21)]
        UM_ShakeDir = 21,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_StatsCrawlMsg", Value = 22)]
        UM_StatsCrawlMsg = 22,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_StatsSkipState", Value = 23)]
        UM_StatsSkipState = 23,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_TextMsg", Value = 24)]
        UM_TextMsg = 24,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_Tilt", Value = 25)]
        UM_Tilt = 25,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_Train", Value = 26)]
        UM_Train = 26,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_VGUIMenu", Value = 27)]
        UM_VGUIMenu = 27,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_VoiceMask", Value = 28)]
        UM_VoiceMask = 28,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_VoiceSubtitle", Value = 29)]
        UM_VoiceSubtitle = 29,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_SendAudio", Value = 30)]
        UM_SendAudio = 30,

        [global::ProtoBuf.ProtoEnum(Name = @"UM_MAX_BASE", Value = 63)]
        UM_MAX_BASE = 63
    }

    [global::ProtoBuf.ProtoContract(Name = @"EDOTAChatWheelMessage")]
    public enum EDOTAChatWheelMessage
    {

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Ok", Value = 0)]
        k_EDOTA_CW_Ok = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Care", Value = 1)]
        k_EDOTA_CW_Care = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_GetBack", Value = 2)]
        k_EDOTA_CW_GetBack = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_NeedWards", Value = 3)]
        k_EDOTA_CW_NeedWards = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Stun", Value = 4)]
        k_EDOTA_CW_Stun = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Help", Value = 5)]
        k_EDOTA_CW_Help = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Push", Value = 6)]
        k_EDOTA_CW_Push = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_GoodJob", Value = 7)]
        k_EDOTA_CW_GoodJob = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Missing", Value = 8)]
        k_EDOTA_CW_Missing = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Missing_Top", Value = 9)]
        k_EDOTA_CW_Missing_Top = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Missing_Mid", Value = 10)]
        k_EDOTA_CW_Missing_Mid = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_CW_Missing_Bottom", Value = 11)]
        k_EDOTA_CW_Missing_Bottom = 11
    }

    [global::ProtoBuf.ProtoContract(Name = @"EDOTAStatPopupTypes")]
    public enum EDOTAStatPopupTypes
    {

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_SPT_Textline", Value = 0)]
        k_EDOTA_SPT_Textline = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_SPT_Basic", Value = 1)]
        k_EDOTA_SPT_Basic = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"k_EDOTA_SPT_Poll", Value = 2)]
        k_EDOTA_SPT_Poll = 2
    }

    [global::ProtoBuf.ProtoContract(Name = @"Activity")]
    public enum Activity
    {

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_INVALID", Value = -1)]
        ACT_INVALID = -1,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RESET", Value = 0)]
        ACT_RESET = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE", Value = 1)]
        ACT_IDLE = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_TRANSITION", Value = 2)]
        ACT_TRANSITION = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COVER", Value = 3)]
        ACT_COVER = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COVER_MED", Value = 4)]
        ACT_COVER_MED = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COVER_LOW", Value = 5)]
        ACT_COVER_LOW = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK", Value = 6)]
        ACT_WALK = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM", Value = 7)]
        ACT_WALK_AIM = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_CROUCH", Value = 8)]
        ACT_WALK_CROUCH = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_CROUCH_AIM", Value = 9)]
        ACT_WALK_CROUCH_AIM = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN", Value = 10)]
        ACT_RUN = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM", Value = 11)]
        ACT_RUN_AIM = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_CROUCH", Value = 12)]
        ACT_RUN_CROUCH = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_CROUCH_AIM", Value = 13)]
        ACT_RUN_CROUCH_AIM = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_PROTECTED", Value = 14)]
        ACT_RUN_PROTECTED = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SCRIPT_CUSTOM_MOVE", Value = 15)]
        ACT_SCRIPT_CUSTOM_MOVE = 15,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK1", Value = 16)]
        ACT_RANGE_ATTACK1 = 16,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK2", Value = 17)]
        ACT_RANGE_ATTACK2 = 17,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK1_LOW", Value = 18)]
        ACT_RANGE_ATTACK1_LOW = 18,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK2_LOW", Value = 19)]
        ACT_RANGE_ATTACK2_LOW = 19,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIESIMPLE", Value = 20)]
        ACT_DIESIMPLE = 20,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIEBACKWARD", Value = 21)]
        ACT_DIEBACKWARD = 21,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIEFORWARD", Value = 22)]
        ACT_DIEFORWARD = 22,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIEVIOLENT", Value = 23)]
        ACT_DIEVIOLENT = 23,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIERAGDOLL", Value = 24)]
        ACT_DIERAGDOLL = 24,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLY", Value = 25)]
        ACT_FLY = 25,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_HOVER", Value = 26)]
        ACT_HOVER = 26,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GLIDE", Value = 27)]
        ACT_GLIDE = 27,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SWIM", Value = 28)]
        ACT_SWIM = 28,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_JUMP", Value = 29)]
        ACT_JUMP = 29,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_HOP", Value = 30)]
        ACT_HOP = 30,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_LEAP", Value = 31)]
        ACT_LEAP = 31,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_LAND", Value = 32)]
        ACT_LAND = 32,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CLIMB_UP", Value = 33)]
        ACT_CLIMB_UP = 33,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CLIMB_DOWN", Value = 34)]
        ACT_CLIMB_DOWN = 34,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CLIMB_DISMOUNT", Value = 35)]
        ACT_CLIMB_DISMOUNT = 35,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SHIPLADDER_UP", Value = 36)]
        ACT_SHIPLADDER_UP = 36,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SHIPLADDER_DOWN", Value = 37)]
        ACT_SHIPLADDER_DOWN = 37,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STRAFE_LEFT", Value = 38)]
        ACT_STRAFE_LEFT = 38,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STRAFE_RIGHT", Value = 39)]
        ACT_STRAFE_RIGHT = 39,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_ROLL_LEFT", Value = 40)]
        ACT_ROLL_LEFT = 40,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_ROLL_RIGHT", Value = 41)]
        ACT_ROLL_RIGHT = 41,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_TURN_LEFT", Value = 42)]
        ACT_TURN_LEFT = 42,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_TURN_RIGHT", Value = 43)]
        ACT_TURN_RIGHT = 43,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CROUCH", Value = 44)]
        ACT_CROUCH = 44,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CROUCHIDLE", Value = 45)]
        ACT_CROUCHIDLE = 45,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STAND", Value = 46)]
        ACT_STAND = 46,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_USE", Value = 47)]
        ACT_USE = 47,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_ALIEN_BURROW_IDLE", Value = 48)]
        ACT_ALIEN_BURROW_IDLE = 48,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_ALIEN_BURROW_OUT", Value = 49)]
        ACT_ALIEN_BURROW_OUT = 49,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL1", Value = 50)]
        ACT_SIGNAL1 = 50,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL2", Value = 51)]
        ACT_SIGNAL2 = 51,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL3", Value = 52)]
        ACT_SIGNAL3 = 52,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL_ADVANCE", Value = 53)]
        ACT_SIGNAL_ADVANCE = 53,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL_FORWARD", Value = 54)]
        ACT_SIGNAL_FORWARD = 54,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL_GROUP", Value = 55)]
        ACT_SIGNAL_GROUP = 55,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL_HALT", Value = 56)]
        ACT_SIGNAL_HALT = 56,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL_LEFT", Value = 57)]
        ACT_SIGNAL_LEFT = 57,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL_RIGHT", Value = 58)]
        ACT_SIGNAL_RIGHT = 58,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SIGNAL_TAKECOVER", Value = 59)]
        ACT_SIGNAL_TAKECOVER = 59,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_LOOKBACK_RIGHT", Value = 60)]
        ACT_LOOKBACK_RIGHT = 60,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_LOOKBACK_LEFT", Value = 61)]
        ACT_LOOKBACK_LEFT = 61,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COWER", Value = 62)]
        ACT_COWER = 62,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMALL_FLINCH", Value = 63)]
        ACT_SMALL_FLINCH = 63,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BIG_FLINCH", Value = 64)]
        ACT_BIG_FLINCH = 64,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_MELEE_ATTACK1", Value = 65)]
        ACT_MELEE_ATTACK1 = 65,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_MELEE_ATTACK2", Value = 66)]
        ACT_MELEE_ATTACK2 = 66,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD", Value = 67)]
        ACT_RELOAD = 67,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_START", Value = 68)]
        ACT_RELOAD_START = 68,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_FINISH", Value = 69)]
        ACT_RELOAD_FINISH = 69,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_LOW", Value = 70)]
        ACT_RELOAD_LOW = 70,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_ARM", Value = 71)]
        ACT_ARM = 71,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DISARM", Value = 72)]
        ACT_DISARM = 72,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DROP_WEAPON", Value = 73)]
        ACT_DROP_WEAPON = 73,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DROP_WEAPON_SHOTGUN", Value = 74)]
        ACT_DROP_WEAPON_SHOTGUN = 74,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_PICKUP_GROUND", Value = 75)]
        ACT_PICKUP_GROUND = 75,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_PICKUP_RACK", Value = 76)]
        ACT_PICKUP_RACK = 76,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_ANGRY", Value = 77)]
        ACT_IDLE_ANGRY = 77,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_RELAXED", Value = 78)]
        ACT_IDLE_RELAXED = 78,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_STIMULATED", Value = 79)]
        ACT_IDLE_STIMULATED = 79,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_AGITATED", Value = 80)]
        ACT_IDLE_AGITATED = 80,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_STEALTH", Value = 81)]
        ACT_IDLE_STEALTH = 81,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_HURT", Value = 82)]
        ACT_IDLE_HURT = 82,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_RELAXED", Value = 83)]
        ACT_WALK_RELAXED = 83,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_STIMULATED", Value = 84)]
        ACT_WALK_STIMULATED = 84,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AGITATED", Value = 85)]
        ACT_WALK_AGITATED = 85,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_STEALTH", Value = 86)]
        ACT_WALK_STEALTH = 86,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_RELAXED", Value = 87)]
        ACT_RUN_RELAXED = 87,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_STIMULATED", Value = 88)]
        ACT_RUN_STIMULATED = 88,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AGITATED", Value = 89)]
        ACT_RUN_AGITATED = 89,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_STEALTH", Value = 90)]
        ACT_RUN_STEALTH = 90,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_AIM_RELAXED", Value = 91)]
        ACT_IDLE_AIM_RELAXED = 91,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_AIM_STIMULATED", Value = 92)]
        ACT_IDLE_AIM_STIMULATED = 92,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_AIM_AGITATED", Value = 93)]
        ACT_IDLE_AIM_AGITATED = 93,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_AIM_STEALTH", Value = 94)]
        ACT_IDLE_AIM_STEALTH = 94,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_RELAXED", Value = 95)]
        ACT_WALK_AIM_RELAXED = 95,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_STIMULATED", Value = 96)]
        ACT_WALK_AIM_STIMULATED = 96,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_AGITATED", Value = 97)]
        ACT_WALK_AIM_AGITATED = 97,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_STEALTH", Value = 98)]
        ACT_WALK_AIM_STEALTH = 98,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_RELAXED", Value = 99)]
        ACT_RUN_AIM_RELAXED = 99,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_STIMULATED", Value = 100)]
        ACT_RUN_AIM_STIMULATED = 100,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_AGITATED", Value = 101)]
        ACT_RUN_AIM_AGITATED = 101,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_STEALTH", Value = 102)]
        ACT_RUN_AIM_STEALTH = 102,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CROUCHIDLE_STIMULATED", Value = 103)]
        ACT_CROUCHIDLE_STIMULATED = 103,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CROUCHIDLE_AIM_STIMULATED", Value = 104)]
        ACT_CROUCHIDLE_AIM_STIMULATED = 104,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_CROUCHIDLE_AGITATED", Value = 105)]
        ACT_CROUCHIDLE_AGITATED = 105,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_HURT", Value = 106)]
        ACT_WALK_HURT = 106,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_HURT", Value = 107)]
        ACT_RUN_HURT = 107,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SPECIAL_ATTACK1", Value = 108)]
        ACT_SPECIAL_ATTACK1 = 108,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SPECIAL_ATTACK2", Value = 109)]
        ACT_SPECIAL_ATTACK2 = 109,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COMBAT_IDLE", Value = 110)]
        ACT_COMBAT_IDLE = 110,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_SCARED", Value = 111)]
        ACT_WALK_SCARED = 111,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_SCARED", Value = 112)]
        ACT_RUN_SCARED = 112,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VICTORY_DANCE", Value = 113)]
        ACT_VICTORY_DANCE = 113,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_HEADSHOT", Value = 114)]
        ACT_DIE_HEADSHOT = 114,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_CHESTSHOT", Value = 115)]
        ACT_DIE_CHESTSHOT = 115,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_GUTSHOT", Value = 116)]
        ACT_DIE_GUTSHOT = 116,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_BACKSHOT", Value = 117)]
        ACT_DIE_BACKSHOT = 117,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_HEAD", Value = 118)]
        ACT_FLINCH_HEAD = 118,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_CHEST", Value = 119)]
        ACT_FLINCH_CHEST = 119,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_STOMACH", Value = 120)]
        ACT_FLINCH_STOMACH = 120,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_LEFTARM", Value = 121)]
        ACT_FLINCH_LEFTARM = 121,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_RIGHTARM", Value = 122)]
        ACT_FLINCH_RIGHTARM = 122,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_LEFTLEG", Value = 123)]
        ACT_FLINCH_LEFTLEG = 123,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_RIGHTLEG", Value = 124)]
        ACT_FLINCH_RIGHTLEG = 124,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_PHYSICS", Value = 125)]
        ACT_FLINCH_PHYSICS = 125,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_HEAD_BACK", Value = 126)]
        ACT_FLINCH_HEAD_BACK = 126,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_CHEST_BACK", Value = 127)]
        ACT_FLINCH_CHEST_BACK = 127,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_STOMACH_BACK", Value = 128)]
        ACT_FLINCH_STOMACH_BACK = 128,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_CROUCH_FRONT", Value = 129)]
        ACT_FLINCH_CROUCH_FRONT = 129,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_CROUCH_BACK", Value = 130)]
        ACT_FLINCH_CROUCH_BACK = 130,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_CROUCH_LEFT", Value = 131)]
        ACT_FLINCH_CROUCH_LEFT = 131,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_FLINCH_CROUCH_RIGHT", Value = 132)]
        ACT_FLINCH_CROUCH_RIGHT = 132,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_ON_FIRE", Value = 133)]
        ACT_IDLE_ON_FIRE = 133,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_ON_FIRE", Value = 134)]
        ACT_WALK_ON_FIRE = 134,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_ON_FIRE", Value = 135)]
        ACT_RUN_ON_FIRE = 135,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RAPPEL_LOOP", Value = 136)]
        ACT_RAPPEL_LOOP = 136,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_180_LEFT", Value = 137)]
        ACT_180_LEFT = 137,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_180_RIGHT", Value = 138)]
        ACT_180_RIGHT = 138,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_90_LEFT", Value = 139)]
        ACT_90_LEFT = 139,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_90_RIGHT", Value = 140)]
        ACT_90_RIGHT = 140,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STEP_LEFT", Value = 141)]
        ACT_STEP_LEFT = 141,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STEP_RIGHT", Value = 142)]
        ACT_STEP_RIGHT = 142,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STEP_BACK", Value = 143)]
        ACT_STEP_BACK = 143,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STEP_FORE", Value = 144)]
        ACT_STEP_FORE = 144,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK1", Value = 145)]
        ACT_GESTURE_RANGE_ATTACK1 = 145,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK2", Value = 146)]
        ACT_GESTURE_RANGE_ATTACK2 = 146,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_MELEE_ATTACK1", Value = 147)]
        ACT_GESTURE_MELEE_ATTACK1 = 147,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_MELEE_ATTACK2", Value = 148)]
        ACT_GESTURE_MELEE_ATTACK2 = 148,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK1_LOW", Value = 149)]
        ACT_GESTURE_RANGE_ATTACK1_LOW = 149,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK2_LOW", Value = 150)]
        ACT_GESTURE_RANGE_ATTACK2_LOW = 150,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_MELEE_ATTACK_SWING_GESTURE", Value = 151)]
        ACT_MELEE_ATTACK_SWING_GESTURE = 151,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_SMALL_FLINCH", Value = 152)]
        ACT_GESTURE_SMALL_FLINCH = 152,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_BIG_FLINCH", Value = 153)]
        ACT_GESTURE_BIG_FLINCH = 153,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_BLAST", Value = 154)]
        ACT_GESTURE_FLINCH_BLAST = 154,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_BLAST_SHOTGUN", Value = 155)]
        ACT_GESTURE_FLINCH_BLAST_SHOTGUN = 155,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_BLAST_DAMAGED", Value = 156)]
        ACT_GESTURE_FLINCH_BLAST_DAMAGED = 156,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_BLAST_DAMAGED_SHOTGUN", Value = 157)]
        ACT_GESTURE_FLINCH_BLAST_DAMAGED_SHOTGUN = 157,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_HEAD", Value = 158)]
        ACT_GESTURE_FLINCH_HEAD = 158,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_CHEST", Value = 159)]
        ACT_GESTURE_FLINCH_CHEST = 159,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_STOMACH", Value = 160)]
        ACT_GESTURE_FLINCH_STOMACH = 160,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_LEFTARM", Value = 161)]
        ACT_GESTURE_FLINCH_LEFTARM = 161,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_RIGHTARM", Value = 162)]
        ACT_GESTURE_FLINCH_RIGHTARM = 162,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_LEFTLEG", Value = 163)]
        ACT_GESTURE_FLINCH_LEFTLEG = 163,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_FLINCH_RIGHTLEG", Value = 164)]
        ACT_GESTURE_FLINCH_RIGHTLEG = 164,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_LEFT", Value = 165)]
        ACT_GESTURE_TURN_LEFT = 165,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_RIGHT", Value = 166)]
        ACT_GESTURE_TURN_RIGHT = 166,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_LEFT45", Value = 167)]
        ACT_GESTURE_TURN_LEFT45 = 167,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_RIGHT45", Value = 168)]
        ACT_GESTURE_TURN_RIGHT45 = 168,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_LEFT90", Value = 169)]
        ACT_GESTURE_TURN_LEFT90 = 169,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_RIGHT90", Value = 170)]
        ACT_GESTURE_TURN_RIGHT90 = 170,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_LEFT45_FLAT", Value = 171)]
        ACT_GESTURE_TURN_LEFT45_FLAT = 171,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_RIGHT45_FLAT", Value = 172)]
        ACT_GESTURE_TURN_RIGHT45_FLAT = 172,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_LEFT90_FLAT", Value = 173)]
        ACT_GESTURE_TURN_LEFT90_FLAT = 173,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_TURN_RIGHT90_FLAT", Value = 174)]
        ACT_GESTURE_TURN_RIGHT90_FLAT = 174,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BARNACLE_HIT", Value = 175)]
        ACT_BARNACLE_HIT = 175,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BARNACLE_PULL", Value = 176)]
        ACT_BARNACLE_PULL = 176,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BARNACLE_CHOMP", Value = 177)]
        ACT_BARNACLE_CHOMP = 177,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BARNACLE_CHEW", Value = 178)]
        ACT_BARNACLE_CHEW = 178,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DO_NOT_DISTURB", Value = 179)]
        ACT_DO_NOT_DISTURB = 179,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SPECIFIC_SEQUENCE", Value = 180)]
        ACT_SPECIFIC_SEQUENCE = 180,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_DRAW", Value = 181)]
        ACT_VM_DRAW = 181,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HOLSTER", Value = 182)]
        ACT_VM_HOLSTER = 182,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_IDLE", Value = 183)]
        ACT_VM_IDLE = 183,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_FIDGET", Value = 184)]
        ACT_VM_FIDGET = 184,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_PULLBACK", Value = 185)]
        ACT_VM_PULLBACK = 185,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_PULLBACK_HIGH", Value = 186)]
        ACT_VM_PULLBACK_HIGH = 186,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_PULLBACK_LOW", Value = 187)]
        ACT_VM_PULLBACK_LOW = 187,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_THROW", Value = 188)]
        ACT_VM_THROW = 188,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_PULLPIN", Value = 189)]
        ACT_VM_PULLPIN = 189,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_PRIMARYATTACK", Value = 190)]
        ACT_VM_PRIMARYATTACK = 190,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_SECONDARYATTACK", Value = 191)]
        ACT_VM_SECONDARYATTACK = 191,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_RELOAD", Value = 192)]
        ACT_VM_RELOAD = 192,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_DRYFIRE", Value = 193)]
        ACT_VM_DRYFIRE = 193,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HITLEFT", Value = 194)]
        ACT_VM_HITLEFT = 194,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HITLEFT2", Value = 195)]
        ACT_VM_HITLEFT2 = 195,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HITRIGHT", Value = 196)]
        ACT_VM_HITRIGHT = 196,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HITRIGHT2", Value = 197)]
        ACT_VM_HITRIGHT2 = 197,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HITCENTER", Value = 198)]
        ACT_VM_HITCENTER = 198,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HITCENTER2", Value = 199)]
        ACT_VM_HITCENTER2 = 199,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_MISSLEFT", Value = 200)]
        ACT_VM_MISSLEFT = 200,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_MISSLEFT2", Value = 201)]
        ACT_VM_MISSLEFT2 = 201,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_MISSRIGHT", Value = 202)]
        ACT_VM_MISSRIGHT = 202,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_MISSRIGHT2", Value = 203)]
        ACT_VM_MISSRIGHT2 = 203,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_MISSCENTER", Value = 204)]
        ACT_VM_MISSCENTER = 204,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_MISSCENTER2", Value = 205)]
        ACT_VM_MISSCENTER2 = 205,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_HAULBACK", Value = 206)]
        ACT_VM_HAULBACK = 206,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_SWINGHARD", Value = 207)]
        ACT_VM_SWINGHARD = 207,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_SWINGMISS", Value = 208)]
        ACT_VM_SWINGMISS = 208,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_SWINGHIT", Value = 209)]
        ACT_VM_SWINGHIT = 209,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_IDLE_TO_LOWERED", Value = 210)]
        ACT_VM_IDLE_TO_LOWERED = 210,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_IDLE_LOWERED", Value = 211)]
        ACT_VM_IDLE_LOWERED = 211,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_LOWERED_TO_IDLE", Value = 212)]
        ACT_VM_LOWERED_TO_IDLE = 212,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_RECOIL1", Value = 213)]
        ACT_VM_RECOIL1 = 213,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_RECOIL2", Value = 214)]
        ACT_VM_RECOIL2 = 214,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_RECOIL3", Value = 215)]
        ACT_VM_RECOIL3 = 215,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_PICKUP", Value = 216)]
        ACT_VM_PICKUP = 216,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_RELEASE", Value = 217)]
        ACT_VM_RELEASE = 217,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_ATTACH_SILENCER", Value = 218)]
        ACT_VM_ATTACH_SILENCER = 218,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_VM_DETACH_SILENCER", Value = 219)]
        ACT_VM_DETACH_SILENCER = 219,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_IDLE", Value = 220)]
        ACT_SLAM_STICKWALL_IDLE = 220,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_ND_IDLE", Value = 221)]
        ACT_SLAM_STICKWALL_ND_IDLE = 221,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_ATTACH", Value = 222)]
        ACT_SLAM_STICKWALL_ATTACH = 222,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_ATTACH2", Value = 223)]
        ACT_SLAM_STICKWALL_ATTACH2 = 223,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_ND_ATTACH", Value = 224)]
        ACT_SLAM_STICKWALL_ND_ATTACH = 224,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_ND_ATTACH2", Value = 225)]
        ACT_SLAM_STICKWALL_ND_ATTACH2 = 225,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_DETONATE", Value = 226)]
        ACT_SLAM_STICKWALL_DETONATE = 226,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_DETONATOR_HOLSTER", Value = 227)]
        ACT_SLAM_STICKWALL_DETONATOR_HOLSTER = 227,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_DRAW", Value = 228)]
        ACT_SLAM_STICKWALL_DRAW = 228,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_ND_DRAW", Value = 229)]
        ACT_SLAM_STICKWALL_ND_DRAW = 229,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_TO_THROW", Value = 230)]
        ACT_SLAM_STICKWALL_TO_THROW = 230,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_TO_THROW_ND", Value = 231)]
        ACT_SLAM_STICKWALL_TO_THROW_ND = 231,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_STICKWALL_TO_TRIPMINE_ND", Value = 232)]
        ACT_SLAM_STICKWALL_TO_TRIPMINE_ND = 232,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_IDLE", Value = 233)]
        ACT_SLAM_THROW_IDLE = 233,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_ND_IDLE", Value = 234)]
        ACT_SLAM_THROW_ND_IDLE = 234,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_THROW", Value = 235)]
        ACT_SLAM_THROW_THROW = 235,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_THROW2", Value = 236)]
        ACT_SLAM_THROW_THROW2 = 236,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_THROW_ND", Value = 237)]
        ACT_SLAM_THROW_THROW_ND = 237,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_THROW_ND2", Value = 238)]
        ACT_SLAM_THROW_THROW_ND2 = 238,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_DRAW", Value = 239)]
        ACT_SLAM_THROW_DRAW = 239,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_ND_DRAW", Value = 240)]
        ACT_SLAM_THROW_ND_DRAW = 240,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_TO_STICKWALL", Value = 241)]
        ACT_SLAM_THROW_TO_STICKWALL = 241,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_TO_STICKWALL_ND", Value = 242)]
        ACT_SLAM_THROW_TO_STICKWALL_ND = 242,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_DETONATE", Value = 243)]
        ACT_SLAM_THROW_DETONATE = 243,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_DETONATOR_HOLSTER", Value = 244)]
        ACT_SLAM_THROW_DETONATOR_HOLSTER = 244,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_THROW_TO_TRIPMINE_ND", Value = 245)]
        ACT_SLAM_THROW_TO_TRIPMINE_ND = 245,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_TRIPMINE_IDLE", Value = 246)]
        ACT_SLAM_TRIPMINE_IDLE = 246,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_TRIPMINE_DRAW", Value = 247)]
        ACT_SLAM_TRIPMINE_DRAW = 247,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_TRIPMINE_ATTACH", Value = 248)]
        ACT_SLAM_TRIPMINE_ATTACH = 248,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_TRIPMINE_ATTACH2", Value = 249)]
        ACT_SLAM_TRIPMINE_ATTACH2 = 249,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_TRIPMINE_TO_STICKWALL_ND", Value = 250)]
        ACT_SLAM_TRIPMINE_TO_STICKWALL_ND = 250,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_TRIPMINE_TO_THROW_ND", Value = 251)]
        ACT_SLAM_TRIPMINE_TO_THROW_ND = 251,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_DETONATOR_IDLE", Value = 252)]
        ACT_SLAM_DETONATOR_IDLE = 252,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_DETONATOR_DRAW", Value = 253)]
        ACT_SLAM_DETONATOR_DRAW = 253,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_DETONATOR_DETONATE", Value = 254)]
        ACT_SLAM_DETONATOR_DETONATE = 254,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_DETONATOR_HOLSTER", Value = 255)]
        ACT_SLAM_DETONATOR_HOLSTER = 255,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_DETONATOR_STICKWALL_DRAW", Value = 256)]
        ACT_SLAM_DETONATOR_STICKWALL_DRAW = 256,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SLAM_DETONATOR_THROW_DRAW", Value = 257)]
        ACT_SLAM_DETONATOR_THROW_DRAW = 257,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SHOTGUN_RELOAD_START", Value = 258)]
        ACT_SHOTGUN_RELOAD_START = 258,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SHOTGUN_RELOAD_FINISH", Value = 259)]
        ACT_SHOTGUN_RELOAD_FINISH = 259,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SHOTGUN_PUMP", Value = 260)]
        ACT_SHOTGUN_PUMP = 260,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMG2_IDLE2", Value = 261)]
        ACT_SMG2_IDLE2 = 261,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMG2_FIRE2", Value = 262)]
        ACT_SMG2_FIRE2 = 262,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMG2_DRAW2", Value = 263)]
        ACT_SMG2_DRAW2 = 263,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMG2_RELOAD2", Value = 264)]
        ACT_SMG2_RELOAD2 = 264,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMG2_DRYFIRE2", Value = 265)]
        ACT_SMG2_DRYFIRE2 = 265,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMG2_TOAUTO", Value = 266)]
        ACT_SMG2_TOAUTO = 266,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_SMG2_TOBURST", Value = 267)]
        ACT_SMG2_TOBURST = 267,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_PHYSCANNON_UPGRADE", Value = 268)]
        ACT_PHYSCANNON_UPGRADE = 268,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_AR1", Value = 269)]
        ACT_RANGE_ATTACK_AR1 = 269,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_AR2", Value = 270)]
        ACT_RANGE_ATTACK_AR2 = 270,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_AR2_LOW", Value = 271)]
        ACT_RANGE_ATTACK_AR2_LOW = 271,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_AR2_GRENADE", Value = 272)]
        ACT_RANGE_ATTACK_AR2_GRENADE = 272,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_HMG1", Value = 273)]
        ACT_RANGE_ATTACK_HMG1 = 273,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_ML", Value = 274)]
        ACT_RANGE_ATTACK_ML = 274,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_SMG1", Value = 275)]
        ACT_RANGE_ATTACK_SMG1 = 275,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_SMG1_LOW", Value = 276)]
        ACT_RANGE_ATTACK_SMG1_LOW = 276,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_SMG2", Value = 277)]
        ACT_RANGE_ATTACK_SMG2 = 277,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_SHOTGUN", Value = 278)]
        ACT_RANGE_ATTACK_SHOTGUN = 278,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_SHOTGUN_LOW", Value = 279)]
        ACT_RANGE_ATTACK_SHOTGUN_LOW = 279,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_PISTOL", Value = 280)]
        ACT_RANGE_ATTACK_PISTOL = 280,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_PISTOL_LOW", Value = 281)]
        ACT_RANGE_ATTACK_PISTOL_LOW = 281,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_SLAM", Value = 282)]
        ACT_RANGE_ATTACK_SLAM = 282,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_TRIPWIRE", Value = 283)]
        ACT_RANGE_ATTACK_TRIPWIRE = 283,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_THROW", Value = 284)]
        ACT_RANGE_ATTACK_THROW = 284,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_SNIPER_RIFLE", Value = 285)]
        ACT_RANGE_ATTACK_SNIPER_RIFLE = 285,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_ATTACK_RPG", Value = 286)]
        ACT_RANGE_ATTACK_RPG = 286,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_MELEE_ATTACK_SWING", Value = 287)]
        ACT_MELEE_ATTACK_SWING = 287,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_AIM_LOW", Value = 288)]
        ACT_RANGE_AIM_LOW = 288,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_AIM_SMG1_LOW", Value = 289)]
        ACT_RANGE_AIM_SMG1_LOW = 289,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_AIM_PISTOL_LOW", Value = 290)]
        ACT_RANGE_AIM_PISTOL_LOW = 290,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RANGE_AIM_AR2_LOW", Value = 291)]
        ACT_RANGE_AIM_AR2_LOW = 291,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COVER_PISTOL_LOW", Value = 292)]
        ACT_COVER_PISTOL_LOW = 292,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COVER_SMG1_LOW", Value = 293)]
        ACT_COVER_SMG1_LOW = 293,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_AR1", Value = 294)]
        ACT_GESTURE_RANGE_ATTACK_AR1 = 294,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_AR2", Value = 295)]
        ACT_GESTURE_RANGE_ATTACK_AR2 = 295,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_AR2_GRENADE", Value = 296)]
        ACT_GESTURE_RANGE_ATTACK_AR2_GRENADE = 296,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_HMG1", Value = 297)]
        ACT_GESTURE_RANGE_ATTACK_HMG1 = 297,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_ML", Value = 298)]
        ACT_GESTURE_RANGE_ATTACK_ML = 298,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_SMG1", Value = 299)]
        ACT_GESTURE_RANGE_ATTACK_SMG1 = 299,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_SMG1_LOW", Value = 300)]
        ACT_GESTURE_RANGE_ATTACK_SMG1_LOW = 300,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_SMG2", Value = 301)]
        ACT_GESTURE_RANGE_ATTACK_SMG2 = 301,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_SHOTGUN", Value = 302)]
        ACT_GESTURE_RANGE_ATTACK_SHOTGUN = 302,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_PISTOL", Value = 303)]
        ACT_GESTURE_RANGE_ATTACK_PISTOL = 303,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_PISTOL_LOW", Value = 304)]
        ACT_GESTURE_RANGE_ATTACK_PISTOL_LOW = 304,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_SLAM", Value = 305)]
        ACT_GESTURE_RANGE_ATTACK_SLAM = 305,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_TRIPWIRE", Value = 306)]
        ACT_GESTURE_RANGE_ATTACK_TRIPWIRE = 306,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_THROW", Value = 307)]
        ACT_GESTURE_RANGE_ATTACK_THROW = 307,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RANGE_ATTACK_SNIPER_RIFLE", Value = 308)]
        ACT_GESTURE_RANGE_ATTACK_SNIPER_RIFLE = 308,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_MELEE_ATTACK_SWING", Value = 309)]
        ACT_GESTURE_MELEE_ATTACK_SWING = 309,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_RIFLE", Value = 310)]
        ACT_IDLE_RIFLE = 310,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_SMG1", Value = 311)]
        ACT_IDLE_SMG1 = 311,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_ANGRY_SMG1", Value = 312)]
        ACT_IDLE_ANGRY_SMG1 = 312,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_PISTOL", Value = 313)]
        ACT_IDLE_PISTOL = 313,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_ANGRY_PISTOL", Value = 314)]
        ACT_IDLE_ANGRY_PISTOL = 314,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_ANGRY_SHOTGUN", Value = 315)]
        ACT_IDLE_ANGRY_SHOTGUN = 315,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_STEALTH_PISTOL", Value = 316)]
        ACT_IDLE_STEALTH_PISTOL = 316,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_PACKAGE", Value = 317)]
        ACT_IDLE_PACKAGE = 317,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_PACKAGE", Value = 318)]
        ACT_WALK_PACKAGE = 318,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_SUITCASE", Value = 319)]
        ACT_IDLE_SUITCASE = 319,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_SUITCASE", Value = 320)]
        ACT_WALK_SUITCASE = 320,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_SMG1_RELAXED", Value = 321)]
        ACT_IDLE_SMG1_RELAXED = 321,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_SMG1_STIMULATED", Value = 322)]
        ACT_IDLE_SMG1_STIMULATED = 322,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_RIFLE_RELAXED", Value = 323)]
        ACT_WALK_RIFLE_RELAXED = 323,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_RIFLE_RELAXED", Value = 324)]
        ACT_RUN_RIFLE_RELAXED = 324,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_RIFLE_STIMULATED", Value = 325)]
        ACT_WALK_RIFLE_STIMULATED = 325,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_RIFLE_STIMULATED", Value = 326)]
        ACT_RUN_RIFLE_STIMULATED = 326,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_AIM_RIFLE_STIMULATED", Value = 327)]
        ACT_IDLE_AIM_RIFLE_STIMULATED = 327,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_RIFLE_STIMULATED", Value = 328)]
        ACT_WALK_AIM_RIFLE_STIMULATED = 328,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_RIFLE_STIMULATED", Value = 329)]
        ACT_RUN_AIM_RIFLE_STIMULATED = 329,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_SHOTGUN_RELAXED", Value = 330)]
        ACT_IDLE_SHOTGUN_RELAXED = 330,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_SHOTGUN_STIMULATED", Value = 331)]
        ACT_IDLE_SHOTGUN_STIMULATED = 331,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_SHOTGUN_AGITATED", Value = 332)]
        ACT_IDLE_SHOTGUN_AGITATED = 332,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_ANGRY", Value = 333)]
        ACT_WALK_ANGRY = 333,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_POLICE_HARASS1", Value = 334)]
        ACT_POLICE_HARASS1 = 334,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_POLICE_HARASS2", Value = 335)]
        ACT_POLICE_HARASS2 = 335,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_MANNEDGUN", Value = 336)]
        ACT_IDLE_MANNEDGUN = 336,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_MELEE", Value = 337)]
        ACT_IDLE_MELEE = 337,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_ANGRY_MELEE", Value = 338)]
        ACT_IDLE_ANGRY_MELEE = 338,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_RPG_RELAXED", Value = 339)]
        ACT_IDLE_RPG_RELAXED = 339,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_RPG", Value = 340)]
        ACT_IDLE_RPG = 340,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_ANGRY_RPG", Value = 341)]
        ACT_IDLE_ANGRY_RPG = 341,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_COVER_LOW_RPG", Value = 342)]
        ACT_COVER_LOW_RPG = 342,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_RPG", Value = 343)]
        ACT_WALK_RPG = 343,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_RPG", Value = 344)]
        ACT_RUN_RPG = 344,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_CROUCH_RPG", Value = 345)]
        ACT_WALK_CROUCH_RPG = 345,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_CROUCH_RPG", Value = 346)]
        ACT_RUN_CROUCH_RPG = 346,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_RPG_RELAXED", Value = 347)]
        ACT_WALK_RPG_RELAXED = 347,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_RPG_RELAXED", Value = 348)]
        ACT_RUN_RPG_RELAXED = 348,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_RIFLE", Value = 349)]
        ACT_WALK_RIFLE = 349,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_RIFLE", Value = 350)]
        ACT_WALK_AIM_RIFLE = 350,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_CROUCH_RIFLE", Value = 351)]
        ACT_WALK_CROUCH_RIFLE = 351,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_CROUCH_AIM_RIFLE", Value = 352)]
        ACT_WALK_CROUCH_AIM_RIFLE = 352,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_RIFLE", Value = 353)]
        ACT_RUN_RIFLE = 353,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_RIFLE", Value = 354)]
        ACT_RUN_AIM_RIFLE = 354,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_CROUCH_RIFLE", Value = 355)]
        ACT_RUN_CROUCH_RIFLE = 355,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_CROUCH_AIM_RIFLE", Value = 356)]
        ACT_RUN_CROUCH_AIM_RIFLE = 356,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_STEALTH_PISTOL", Value = 357)]
        ACT_RUN_STEALTH_PISTOL = 357,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_SHOTGUN", Value = 358)]
        ACT_WALK_AIM_SHOTGUN = 358,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_SHOTGUN", Value = 359)]
        ACT_RUN_AIM_SHOTGUN = 359,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_PISTOL", Value = 360)]
        ACT_WALK_PISTOL = 360,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_PISTOL", Value = 361)]
        ACT_RUN_PISTOL = 361,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_PISTOL", Value = 362)]
        ACT_WALK_AIM_PISTOL = 362,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_PISTOL", Value = 363)]
        ACT_RUN_AIM_PISTOL = 363,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_STEALTH_PISTOL", Value = 364)]
        ACT_WALK_STEALTH_PISTOL = 364,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_AIM_STEALTH_PISTOL", Value = 365)]
        ACT_WALK_AIM_STEALTH_PISTOL = 365,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RUN_AIM_STEALTH_PISTOL", Value = 366)]
        ACT_RUN_AIM_STEALTH_PISTOL = 366,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_PISTOL", Value = 367)]
        ACT_RELOAD_PISTOL = 367,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_PISTOL_LOW", Value = 368)]
        ACT_RELOAD_PISTOL_LOW = 368,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_SMG1", Value = 369)]
        ACT_RELOAD_SMG1 = 369,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_SMG1_LOW", Value = 370)]
        ACT_RELOAD_SMG1_LOW = 370,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_SHOTGUN", Value = 371)]
        ACT_RELOAD_SHOTGUN = 371,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_RELOAD_SHOTGUN_LOW", Value = 372)]
        ACT_RELOAD_SHOTGUN_LOW = 372,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RELOAD", Value = 373)]
        ACT_GESTURE_RELOAD = 373,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RELOAD_PISTOL", Value = 374)]
        ACT_GESTURE_RELOAD_PISTOL = 374,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RELOAD_SMG1", Value = 375)]
        ACT_GESTURE_RELOAD_SMG1 = 375,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_RELOAD_SHOTGUN", Value = 376)]
        ACT_GESTURE_RELOAD_SHOTGUN = 376,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_LEAN_LEFT", Value = 377)]
        ACT_BUSY_LEAN_LEFT = 377,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_LEAN_LEFT_ENTRY", Value = 378)]
        ACT_BUSY_LEAN_LEFT_ENTRY = 378,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_LEAN_LEFT_EXIT", Value = 379)]
        ACT_BUSY_LEAN_LEFT_EXIT = 379,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_LEAN_BACK", Value = 380)]
        ACT_BUSY_LEAN_BACK = 380,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_LEAN_BACK_ENTRY", Value = 381)]
        ACT_BUSY_LEAN_BACK_ENTRY = 381,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_LEAN_BACK_EXIT", Value = 382)]
        ACT_BUSY_LEAN_BACK_EXIT = 382,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_SIT_GROUND", Value = 383)]
        ACT_BUSY_SIT_GROUND = 383,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_SIT_GROUND_ENTRY", Value = 384)]
        ACT_BUSY_SIT_GROUND_ENTRY = 384,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_SIT_GROUND_EXIT", Value = 385)]
        ACT_BUSY_SIT_GROUND_EXIT = 385,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_SIT_CHAIR", Value = 386)]
        ACT_BUSY_SIT_CHAIR = 386,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_SIT_CHAIR_ENTRY", Value = 387)]
        ACT_BUSY_SIT_CHAIR_ENTRY = 387,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_SIT_CHAIR_EXIT", Value = 388)]
        ACT_BUSY_SIT_CHAIR_EXIT = 388,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_STAND", Value = 389)]
        ACT_BUSY_STAND = 389,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_BUSY_QUEUE", Value = 390)]
        ACT_BUSY_QUEUE = 390,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DUCK_DODGE", Value = 391)]
        ACT_DUCK_DODGE = 391,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_BARNACLE_SWALLOW", Value = 392)]
        ACT_DIE_BARNACLE_SWALLOW = 392,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_GESTURE_BARNACLE_STRANGLE", Value = 393)]
        ACT_GESTURE_BARNACLE_STRANGLE = 393,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_PHYSCANNON_DETACH", Value = 394)]
        ACT_PHYSCANNON_DETACH = 394,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_PHYSCANNON_ANIMATE", Value = 395)]
        ACT_PHYSCANNON_ANIMATE = 395,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_PHYSCANNON_ANIMATE_PRE", Value = 396)]
        ACT_PHYSCANNON_ANIMATE_PRE = 396,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_PHYSCANNON_ANIMATE_POST", Value = 397)]
        ACT_PHYSCANNON_ANIMATE_POST = 397,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_FRONTSIDE", Value = 398)]
        ACT_DIE_FRONTSIDE = 398,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_RIGHTSIDE", Value = 399)]
        ACT_DIE_RIGHTSIDE = 399,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_BACKSIDE", Value = 400)]
        ACT_DIE_BACKSIDE = 400,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DIE_LEFTSIDE", Value = 401)]
        ACT_DIE_LEFTSIDE = 401,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_OPEN_DOOR", Value = 402)]
        ACT_OPEN_DOOR = 402,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DI_ALYX_ZOMBIE_MELEE", Value = 403)]
        ACT_DI_ALYX_ZOMBIE_MELEE = 403,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DI_ALYX_ZOMBIE_TORSO_MELEE", Value = 404)]
        ACT_DI_ALYX_ZOMBIE_TORSO_MELEE = 404,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DI_ALYX_HEADCRAB_MELEE", Value = 405)]
        ACT_DI_ALYX_HEADCRAB_MELEE = 405,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DI_ALYX_ANTLION", Value = 406)]
        ACT_DI_ALYX_ANTLION = 406,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DI_ALYX_ZOMBIE_SHOTGUN64", Value = 407)]
        ACT_DI_ALYX_ZOMBIE_SHOTGUN64 = 407,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DI_ALYX_ZOMBIE_SHOTGUN26", Value = 408)]
        ACT_DI_ALYX_ZOMBIE_SHOTGUN26 = 408,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_RELAXED_TO_STIMULATED", Value = 409)]
        ACT_READINESS_RELAXED_TO_STIMULATED = 409,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_RELAXED_TO_STIMULATED_WALK", Value = 410)]
        ACT_READINESS_RELAXED_TO_STIMULATED_WALK = 410,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_AGITATED_TO_STIMULATED", Value = 411)]
        ACT_READINESS_AGITATED_TO_STIMULATED = 411,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_STIMULATED_TO_RELAXED", Value = 412)]
        ACT_READINESS_STIMULATED_TO_RELAXED = 412,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED", Value = 413)]
        ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED = 413,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED_WALK", Value = 414)]
        ACT_READINESS_PISTOL_RELAXED_TO_STIMULATED_WALK = 414,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_PISTOL_AGITATED_TO_STIMULATED", Value = 415)]
        ACT_READINESS_PISTOL_AGITATED_TO_STIMULATED = 415,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_READINESS_PISTOL_STIMULATED_TO_RELAXED", Value = 416)]
        ACT_READINESS_PISTOL_STIMULATED_TO_RELAXED = 416,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_IDLE_CARRY", Value = 417)]
        ACT_IDLE_CARRY = 417,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WALK_CARRY", Value = 418)]
        ACT_WALK_CARRY = 418,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_IDLE", Value = 419)]
        ACT_DOTA_IDLE = 419,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_IDLE_RARE", Value = 421)]
        ACT_DOTA_IDLE_RARE = 421,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RUN", Value = 422)]
        ACT_DOTA_RUN = 422,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ATTACK", Value = 424)]
        ACT_DOTA_ATTACK = 424,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ATTACK2", Value = 425)]
        ACT_DOTA_ATTACK2 = 425,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ATTACK_EVENT", Value = 426)]
        ACT_DOTA_ATTACK_EVENT = 426,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_DIE", Value = 427)]
        ACT_DOTA_DIE = 427,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_FLINCH", Value = 428)]
        ACT_DOTA_FLINCH = 428,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_FLAIL", Value = 429)]
        ACT_DOTA_FLAIL = 429,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_DISABLED", Value = 430)]
        ACT_DOTA_DISABLED = 430,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_1", Value = 431)]
        ACT_DOTA_CAST_ABILITY_1 = 431,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_2", Value = 432)]
        ACT_DOTA_CAST_ABILITY_2 = 432,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_3", Value = 433)]
        ACT_DOTA_CAST_ABILITY_3 = 433,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_4", Value = 434)]
        ACT_DOTA_CAST_ABILITY_4 = 434,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_5", Value = 435)]
        ACT_DOTA_CAST_ABILITY_5 = 435,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_6", Value = 436)]
        ACT_DOTA_CAST_ABILITY_6 = 436,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_OVERRIDE_ABILITY_1", Value = 437)]
        ACT_DOTA_OVERRIDE_ABILITY_1 = 437,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_OVERRIDE_ABILITY_2", Value = 438)]
        ACT_DOTA_OVERRIDE_ABILITY_2 = 438,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_OVERRIDE_ABILITY_3", Value = 439)]
        ACT_DOTA_OVERRIDE_ABILITY_3 = 439,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_OVERRIDE_ABILITY_4", Value = 440)]
        ACT_DOTA_OVERRIDE_ABILITY_4 = 440,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_ABILITY_1", Value = 441)]
        ACT_DOTA_CHANNEL_ABILITY_1 = 441,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_ABILITY_2", Value = 442)]
        ACT_DOTA_CHANNEL_ABILITY_2 = 442,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_ABILITY_3", Value = 443)]
        ACT_DOTA_CHANNEL_ABILITY_3 = 443,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_ABILITY_4", Value = 444)]
        ACT_DOTA_CHANNEL_ABILITY_4 = 444,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_ABILITY_5", Value = 445)]
        ACT_DOTA_CHANNEL_ABILITY_5 = 445,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_ABILITY_6", Value = 446)]
        ACT_DOTA_CHANNEL_ABILITY_6 = 446,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_END_ABILITY_1", Value = 447)]
        ACT_DOTA_CHANNEL_END_ABILITY_1 = 447,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_END_ABILITY_2", Value = 448)]
        ACT_DOTA_CHANNEL_END_ABILITY_2 = 448,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_END_ABILITY_3", Value = 449)]
        ACT_DOTA_CHANNEL_END_ABILITY_3 = 449,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_END_ABILITY_4", Value = 450)]
        ACT_DOTA_CHANNEL_END_ABILITY_4 = 450,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_END_ABILITY_5", Value = 451)]
        ACT_DOTA_CHANNEL_END_ABILITY_5 = 451,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_END_ABILITY_6", Value = 452)]
        ACT_DOTA_CHANNEL_END_ABILITY_6 = 452,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CONSTANT_LAYER", Value = 453)]
        ACT_DOTA_CONSTANT_LAYER = 453,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAPTURE", Value = 454)]
        ACT_DOTA_CAPTURE = 454,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SPAWN", Value = 455)]
        ACT_DOTA_SPAWN = 455,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_KILLTAUNT", Value = 456)]
        ACT_DOTA_KILLTAUNT = 456,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TAUNT", Value = 457)]
        ACT_DOTA_TAUNT = 457,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_THIRST", Value = 458)]
        ACT_DOTA_THIRST = 458,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_DRAGONBREATH", Value = 459)]
        ACT_DOTA_CAST_DRAGONBREATH = 459,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ECHO_SLAM", Value = 460)]
        ACT_DOTA_ECHO_SLAM = 460,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_1_END", Value = 461)]
        ACT_DOTA_CAST_ABILITY_1_END = 461,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_2_END", Value = 462)]
        ACT_DOTA_CAST_ABILITY_2_END = 462,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_3_END", Value = 463)]
        ACT_DOTA_CAST_ABILITY_3_END = 463,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_4_END", Value = 464)]
        ACT_DOTA_CAST_ABILITY_4_END = 464,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_MIRANA_LEAP_END", Value = 465)]
        ACT_MIRANA_LEAP_END = 465,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WAVEFORM_START", Value = 466)]
        ACT_WAVEFORM_START = 466,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_WAVEFORM_END", Value = 467)]
        ACT_WAVEFORM_END = 467,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_ROT", Value = 468)]
        ACT_DOTA_CAST_ABILITY_ROT = 468,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_DIE_SPECIAL", Value = 469)]
        ACT_DOTA_DIE_SPECIAL = 469,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RATTLETRAP_BATTERYASSAULT", Value = 470)]
        ACT_DOTA_RATTLETRAP_BATTERYASSAULT = 470,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RATTLETRAP_POWERCOGS", Value = 471)]
        ACT_DOTA_RATTLETRAP_POWERCOGS = 471,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RATTLETRAP_HOOKSHOT_START", Value = 472)]
        ACT_DOTA_RATTLETRAP_HOOKSHOT_START = 472,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RATTLETRAP_HOOKSHOT_LOOP", Value = 473)]
        ACT_DOTA_RATTLETRAP_HOOKSHOT_LOOP = 473,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RATTLETRAP_HOOKSHOT_END", Value = 474)]
        ACT_DOTA_RATTLETRAP_HOOKSHOT_END = 474,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_STORM_SPIRIT_OVERLOAD_RUN_OVERRIDE", Value = 475)]
        ACT_STORM_SPIRIT_OVERLOAD_RUN_OVERRIDE = 475,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TINKER_REARM1", Value = 476)]
        ACT_DOTA_TINKER_REARM1 = 476,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TINKER_REARM2", Value = 477)]
        ACT_DOTA_TINKER_REARM2 = 477,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TINKER_REARM3", Value = 478)]
        ACT_DOTA_TINKER_REARM3 = 478,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_TINY_AVALANCHE", Value = 479)]
        ACT_TINY_AVALANCHE = 479,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_TINY_TOSS", Value = 480)]
        ACT_TINY_TOSS = 480,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_TINY_GROWL", Value = 481)]
        ACT_TINY_GROWL = 481,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_WEAVERBUG_ATTACH", Value = 482)]
        ACT_DOTA_WEAVERBUG_ATTACH = 482,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_WILD_AXES_END", Value = 483)]
        ACT_DOTA_CAST_WILD_AXES_END = 483,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_LIFE_BREAK_START", Value = 484)]
        ACT_DOTA_CAST_LIFE_BREAK_START = 484,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_LIFE_BREAK_END", Value = 485)]
        ACT_DOTA_CAST_LIFE_BREAK_END = 485,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_NIGHTSTALKER_TRANSITION", Value = 486)]
        ACT_DOTA_NIGHTSTALKER_TRANSITION = 486,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_LIFESTEALER_RAGE", Value = 487)]
        ACT_DOTA_LIFESTEALER_RAGE = 487,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_LIFESTEALER_OPEN_WOUNDS", Value = 488)]
        ACT_DOTA_LIFESTEALER_OPEN_WOUNDS = 488,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SAND_KING_BURROW_IN", Value = 489)]
        ACT_DOTA_SAND_KING_BURROW_IN = 489,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SAND_KING_BURROW_OUT", Value = 490)]
        ACT_DOTA_SAND_KING_BURROW_OUT = 490,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_EARTHSHAKER_TOTEM_ATTACK", Value = 491)]
        ACT_DOTA_EARTHSHAKER_TOTEM_ATTACK = 491,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_WHEEL_LAYER", Value = 492)]
        ACT_DOTA_WHEEL_LAYER = 492,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_START", Value = 493)]
        ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_START = 493,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ALCHEMIST_CONCOCTION", Value = 494)]
        ACT_DOTA_ALCHEMIST_CONCOCTION = 494,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_JAKIRO_LIQUIDFIRE_START", Value = 495)]
        ACT_DOTA_JAKIRO_LIQUIDFIRE_START = 495,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_JAKIRO_LIQUIDFIRE_LOOP", Value = 496)]
        ACT_DOTA_JAKIRO_LIQUIDFIRE_LOOP = 496,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_LIFESTEALER_INFEST", Value = 497)]
        ACT_DOTA_LIFESTEALER_INFEST = 497,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_LIFESTEALER_INFEST_END", Value = 498)]
        ACT_DOTA_LIFESTEALER_INFEST_END = 498,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_LASSO_LOOP", Value = 499)]
        ACT_DOTA_LASSO_LOOP = 499,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ALCHEMIST_CONCOCTION_THROW", Value = 500)]
        ACT_DOTA_ALCHEMIST_CONCOCTION_THROW = 500,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_END", Value = 501)]
        ACT_DOTA_ALCHEMIST_CHEMICAL_RAGE_END = 501,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_COLD_SNAP", Value = 502)]
        ACT_DOTA_CAST_COLD_SNAP = 502,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_GHOST_WALK", Value = 503)]
        ACT_DOTA_CAST_GHOST_WALK = 503,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_TORNADO", Value = 504)]
        ACT_DOTA_CAST_TORNADO = 504,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_EMP", Value = 505)]
        ACT_DOTA_CAST_EMP = 505,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ALACRITY", Value = 506)]
        ACT_DOTA_CAST_ALACRITY = 506,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_CHAOS_METEOR", Value = 507)]
        ACT_DOTA_CAST_CHAOS_METEOR = 507,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_SUN_STRIKE", Value = 508)]
        ACT_DOTA_CAST_SUN_STRIKE = 508,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_FORGE_SPIRIT", Value = 509)]
        ACT_DOTA_CAST_FORGE_SPIRIT = 509,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ICE_WALL", Value = 510)]
        ACT_DOTA_CAST_ICE_WALL = 510,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_DEAFENING_BLAST", Value = 511)]
        ACT_DOTA_CAST_DEAFENING_BLAST = 511,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_VICTORY", Value = 512)]
        ACT_DOTA_VICTORY = 512,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_DEFEAT", Value = 513)]
        ACT_DOTA_DEFEAT = 513,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SPIRIT_BREAKER_CHARGE_POSE", Value = 514)]
        ACT_DOTA_SPIRIT_BREAKER_CHARGE_POSE = 514,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SPIRIT_BREAKER_CHARGE_END", Value = 515)]
        ACT_DOTA_SPIRIT_BREAKER_CHARGE_END = 515,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TELEPORT", Value = 516)]
        ACT_DOTA_TELEPORT = 516,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TELEPORT_END", Value = 517)]
        ACT_DOTA_TELEPORT_END = 517,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_REFRACTION", Value = 518)]
        ACT_DOTA_CAST_REFRACTION = 518,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAST_ABILITY_7", Value = 519)]
        ACT_DOTA_CAST_ABILITY_7 = 519,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CANCEL_SIREN_SONG", Value = 520)]
        ACT_DOTA_CANCEL_SIREN_SONG = 520,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CHANNEL_ABILITY_7", Value = 521)]
        ACT_DOTA_CHANNEL_ABILITY_7 = 521,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_LOADOUT", Value = 522)]
        ACT_DOTA_LOADOUT = 522,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_FORCESTAFF_END", Value = 523)]
        ACT_DOTA_FORCESTAFF_END = 523,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_POOF_END", Value = 524)]
        ACT_DOTA_POOF_END = 524,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SLARK_POUNCE", Value = 525)]
        ACT_DOTA_SLARK_POUNCE = 525,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_MAGNUS_SKEWER_START", Value = 526)]
        ACT_DOTA_MAGNUS_SKEWER_START = 526,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_MAGNUS_SKEWER_END", Value = 527)]
        ACT_DOTA_MAGNUS_SKEWER_END = 527,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_MEDUSA_STONE_GAZE", Value = 528)]
        ACT_DOTA_MEDUSA_STONE_GAZE = 528,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RELAX_START", Value = 529)]
        ACT_DOTA_RELAX_START = 529,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RELAX_LOOP", Value = 530)]
        ACT_DOTA_RELAX_LOOP = 530,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RELAX_END", Value = 531)]
        ACT_DOTA_RELAX_END = 531,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CENTAUR_STAMPEDE", Value = 532)]
        ACT_DOTA_CENTAUR_STAMPEDE = 532,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_BELLYACHE_START", Value = 533)]
        ACT_DOTA_BELLYACHE_START = 533,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_BELLYACHE_LOOP", Value = 534)]
        ACT_DOTA_BELLYACHE_LOOP = 534,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_BELLYACHE_END", Value = 535)]
        ACT_DOTA_BELLYACHE_END = 535,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ROQUELAIRE_LAND", Value = 536)]
        ACT_DOTA_ROQUELAIRE_LAND = 536,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ROQUELAIRE_LAND_IDLE", Value = 537)]
        ACT_DOTA_ROQUELAIRE_LAND_IDLE = 537,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_GREEVIL_CAST", Value = 538)]
        ACT_DOTA_GREEVIL_CAST = 538,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_GREEVIL_OVERRIDE_ABILITY", Value = 539)]
        ACT_DOTA_GREEVIL_OVERRIDE_ABILITY = 539,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_GREEVIL_HOOK_START", Value = 540)]
        ACT_DOTA_GREEVIL_HOOK_START = 540,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_GREEVIL_HOOK_END", Value = 541)]
        ACT_DOTA_GREEVIL_HOOK_END = 541,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_GREEVIL_BLINK_BONE", Value = 542)]
        ACT_DOTA_GREEVIL_BLINK_BONE = 542,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_IDLE_SLEEPING", Value = 543)]
        ACT_DOTA_IDLE_SLEEPING = 543,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_INTRO", Value = 544)]
        ACT_DOTA_INTRO = 544,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_GESTURE_POINT", Value = 545)]
        ACT_DOTA_GESTURE_POINT = 545,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_GESTURE_ACCENT", Value = 546)]
        ACT_DOTA_GESTURE_ACCENT = 546,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SLEEPING_END", Value = 547)]
        ACT_DOTA_SLEEPING_END = 547,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_AMBUSH", Value = 548)]
        ACT_DOTA_AMBUSH = 548,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_ITEM_LOOK", Value = 549)]
        ACT_DOTA_ITEM_LOOK = 549,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_STARTLE", Value = 550)]
        ACT_DOTA_STARTLE = 550,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_FRUSTRATION", Value = 551)]
        ACT_DOTA_FRUSTRATION = 551,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TELEPORT_REACT", Value = 552)]
        ACT_DOTA_TELEPORT_REACT = 552,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TELEPORT_END_REACT", Value = 553)]
        ACT_DOTA_TELEPORT_END_REACT = 553,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SHRUG", Value = 554)]
        ACT_DOTA_SHRUG = 554,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_RELAX_LOOP_END", Value = 555)]
        ACT_DOTA_RELAX_LOOP_END = 555,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_PRESENT_ITEM", Value = 556)]
        ACT_DOTA_PRESENT_ITEM = 556,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_IDLE_IMPATIENT", Value = 557)]
        ACT_DOTA_IDLE_IMPATIENT = 557,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SHARPEN_WEAPON", Value = 558)]
        ACT_DOTA_SHARPEN_WEAPON = 558,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_SHARPEN_WEAPON_OUT", Value = 559)]
        ACT_DOTA_SHARPEN_WEAPON_OUT = 559,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_IDLE_SLEEPING_END", Value = 560)]
        ACT_DOTA_IDLE_SLEEPING_END = 560,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_BRIDGE_DESTROY", Value = 561)]
        ACT_DOTA_BRIDGE_DESTROY = 561,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_TAUNT_SNIPER", Value = 562)]
        ACT_DOTA_TAUNT_SNIPER = 562,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_DEATH_BY_SNIPER", Value = 563)]
        ACT_DOTA_DEATH_BY_SNIPER = 563,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_LOOK_AROUND", Value = 564)]
        ACT_DOTA_LOOK_AROUND = 564,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAGED_CREEP_RAGE", Value = 565)]
        ACT_DOTA_CAGED_CREEP_RAGE = 565,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAGED_CREEP_RAGE_OUT", Value = 566)]
        ACT_DOTA_CAGED_CREEP_RAGE_OUT = 566,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAGED_CREEP_SMASH", Value = 567)]
        ACT_DOTA_CAGED_CREEP_SMASH = 567,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_CAGED_CREEP_SMASH_OUT", Value = 568)]
        ACT_DOTA_CAGED_CREEP_SMASH_OUT = 568,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_IDLE_IMPATIENT_SWORD_TAP", Value = 569)]
        ACT_DOTA_IDLE_IMPATIENT_SWORD_TAP = 569,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_INTRO_LOOP", Value = 570)]
        ACT_DOTA_INTRO_LOOP = 570,

        [global::ProtoBuf.ProtoEnum(Name = @"ACT_DOTA_BRIDGE_THREAT", Value = 571)]
        ACT_DOTA_BRIDGE_THREAT = 571
    }
}
