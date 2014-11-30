﻿namespace DotaIt.ReplayParser.DemoProto.ProtoDef
{
    using System.ComponentModel;

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDOTAModifierBuffTableEntry")]
    public partial class CDOTAModifierBuffTableEntry : global::ProtoBuf.IExtensible
    {
        public CDOTAModifierBuffTableEntry() { }

        private DOTA_MODIFIER_ENTRY_TYPE _entry_type;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"entry_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public DOTA_MODIFIER_ENTRY_TYPE entry_type
        {
            get { return _entry_type; }
            set { _entry_type = value; }
        }
        private int _parent;
        [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name = @"parent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
        private int _index;
        [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name = @"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int index
        {
            get { return _index; }
            set { _index = value; }
        }
        private int _serial_num;
        [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name = @"serial_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        public int serial_num
        {
            get { return _serial_num; }
            set { _serial_num = value; }
        }
        private int _name = default(int);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _ability_level = default(int);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"ability_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int ability_level
        {
            get { return _ability_level; }
            set { _ability_level = value; }
        }
        private int _stack_count = default(int);
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"stack_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int stack_count
        {
            get { return _stack_count; }
            set { _stack_count = value; }
        }
        private float _creation_time = default(float);
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"creation_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float creation_time
        {
            get { return _creation_time; }
            set { _creation_time = value; }
        }
        private float _duration = (float)-1;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"duration", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue((float)-1)]
        public float duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private int _caster = default(int);
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"caster", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int caster
        {
            get { return _caster; }
            set { _caster = value; }
        }
        private int _ability = default(int);
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"ability", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int ability
        {
            get { return _ability; }
            set { _ability = value; }
        }
        private int _armor = default(int);
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name = @"armor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        private float _fade_time = default(float);
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name = @"fade_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float fade_time
        {
            get { return _fade_time; }
            set { _fade_time = value; }
        }
        private bool _subtle = default(bool);
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"subtle", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool subtle
        {
            get { return _subtle; }
            set { _subtle = value; }
        }
        private float _channel_time = default(float);
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name = @"channel_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float channel_time
        {
            get { return _channel_time; }
            set { _channel_time = value; }
        }
        private CMsgVector _v_start = null;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name = @"v_start", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector v_start
        {
            get { return _v_start; }
            set { _v_start = value; }
        }
        private CMsgVector _v_end = null;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name = @"v_end", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector v_end
        {
            get { return _v_end; }
            set { _v_end = value; }
        }
        private string _portal_loop_appear = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name = @"portal_loop_appear", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string portal_loop_appear
        {
            get { return _portal_loop_appear; }
            set { _portal_loop_appear = value; }
        }
        private string _portal_loop_disappear = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name = @"portal_loop_disappear", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string portal_loop_disappear
        {
            get { return _portal_loop_disappear; }
            set { _portal_loop_disappear = value; }
        }
        private string _hero_loop_appear = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name = @"hero_loop_appear", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string hero_loop_appear
        {
            get { return _hero_loop_appear; }
            set { _hero_loop_appear = value; }
        }
        private string _hero_loop_disappear = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name = @"hero_loop_disappear", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string hero_loop_disappear
        {
            get { return _hero_loop_disappear; }
            set { _hero_loop_disappear = value; }
        }
        private int _movement_speed = default(int);
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name = @"movement_speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int movement_speed
        {
            get { return _movement_speed; }
            set { _movement_speed = value; }
        }
        private bool _aura = default(bool);
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name = @"aura", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool aura
        {
            get { return _aura; }
            set { _aura = value; }
        }
        private int _activity = default(int);
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name = @"activity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int activity
        {
            get { return _activity; }
            set { _activity = value; }
        }
        private int _damage = default(int);
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name = @"damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        private int _range = default(int);
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name = @"range", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int range
        {
            get { return _range; }
            set { _range = value; }
        }
        private int _dd_modifier_index = default(int);
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name = @"dd_modifier_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int dd_modifier_index
        {
            get { return _dd_modifier_index; }
            set { _dd_modifier_index = value; }
        }
        private int _dd_ability_index = default(int);
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name = @"dd_ability_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int dd_ability_index
        {
            get { return _dd_ability_index; }
            set { _dd_ability_index = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"DOTA_MODIFIER_ENTRY_TYPE")]
    public enum DOTA_MODIFIER_ENTRY_TYPE
    {

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_MODIFIER_ENTRY_TYPE_ACTIVE", Value = 1)]
        DOTA_MODIFIER_ENTRY_TYPE_ACTIVE = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"DOTA_MODIFIER_ENTRY_TYPE_REMOVED", Value = 2)]
        DOTA_MODIFIER_ENTRY_TYPE_REMOVED = 2
    }
}