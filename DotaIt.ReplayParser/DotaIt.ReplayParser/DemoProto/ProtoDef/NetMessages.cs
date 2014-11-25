namespace DotaIt.ReplayParser.DemoProto.ProtoDef
{
    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CMsgVector")]
    public partial class CMsgVector : global::ProtoBuf.IExtensible
    {
        public CMsgVector()
        {
        }

        private float _x = default(float);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        private float _y = default(float);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }

        private float _z = default(float);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"z",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float z
        {
            get
            {
                return this._z;
            }
            set
            {
                this._z = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CMsgVector2D")]
    public partial class CMsgVector2D : global::ProtoBuf.IExtensible
    {
        public CMsgVector2D()
        {
        }

        private float _x = default(float);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        private float _y = default(float);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CMsgQAngle")]
    public partial class CMsgQAngle : global::ProtoBuf.IExtensible
    {
        public CMsgQAngle()
        {
        }

        private float _x = default(float);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"x",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        private float _y = default(float);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"y",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }

        private float _z = default(float);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"z",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float z
        {
            get
            {
                return this._z;
            }
            set
            {
                this._z = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_GameEvent")]
    public partial class CSVCMsg_GameEvent : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_GameEvent()
        {
        }

        private string _event_name = "";

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"event_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string event_name
        {
            get
            {
                return this._event_name;
            }
            set
            {
                this._event_name = value;
            }
        }

        private int _eventid = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"eventid",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int eventid
        {
            get
            {
                return this._eventid;
            }
            set
            {
                this._eventid = value;
            }
        }

        private readonly global::System.Collections.Generic.List<CSVCMsg_GameEvent.key_t> _keys =
            new global::System.Collections.Generic.List<CSVCMsg_GameEvent.key_t>();

        [global::ProtoBuf.ProtoMember(3, Name = @"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CSVCMsg_GameEvent.key_t> keys
        {
            get
            {
                return this._keys;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"key_t")]
        public partial class key_t : global::ProtoBuf.IExtensible
        {
            public key_t()
            {
            }

            private int _type = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"type",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int type
            {
                get
                {
                    return this._type;
                }
                set
                {
                    this._type = value;
                }
            }

            private string _val_string = "";

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"val_string",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string val_string
            {
                get
                {
                    return this._val_string;
                }
                set
                {
                    this._val_string = value;
                }
            }

            private float _val_float = default(float);

            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"val_float",
                DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue(default(float))]
            public float val_float
            {
                get
                {
                    return this._val_float;
                }
                set
                {
                    this._val_float = value;
                }
            }

            private int _val_long = default(int);

            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"val_long",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int val_long
            {
                get
                {
                    return this._val_long;
                }
                set
                {
                    this._val_long = value;
                }
            }

            private int _val_short = default(int);

            [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"val_short",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int val_short
            {
                get
                {
                    return this._val_short;
                }
                set
                {
                    this._val_short = value;
                }
            }

            private int _val_byte = default(int);

            [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"val_byte",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int val_byte
            {
                get
                {
                    return this._val_byte;
                }
                set
                {
                    this._val_byte = value;
                }
            }

            private bool _val_bool = default(bool);

            [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"val_bool",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(default(bool))]
            public bool val_bool
            {
                get
                {
                    return this._val_bool;
                }
                set
                {
                    this._val_bool = value;
                }
            }

            private ulong _val_uint64 = default(ulong);

            [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"val_uint64",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(ulong))]
            public ulong val_uint64
            {
                get
                {
                    return this._val_uint64;
                }
                set
                {
                    this._val_uint64 = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsgList_GameEvents")]
    public partial class CSVCMsgList_GameEvents : global::ProtoBuf.IExtensible
    {
        public CSVCMsgList_GameEvents()
        {
        }

        private readonly global::System.Collections.Generic.List<CSVCMsgList_GameEvents.event_t> _events =
            new global::System.Collections.Generic.List<CSVCMsgList_GameEvents.event_t>();

        [global::ProtoBuf.ProtoMember(1, Name = @"events", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CSVCMsgList_GameEvents.event_t> events
        {
            get
            {
                return this._events;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"event_t")]
        public partial class event_t : global::ProtoBuf.IExtensible
        {
            public event_t()
            {
            }

            private int _tick = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"tick",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int tick
            {
                get
                {
                    return this._tick;
                }
                set
                {
                    this._tick = value;
                }
            }

            private CSVCMsg_GameEvent _event = null;

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"event",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CSVCMsg_GameEvent @event
            {
                get
                {
                    return this._event;
                }
                set
                {
                    this._event = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_UserMessage")]
    public partial class CSVCMsg_UserMessage : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_UserMessage()
        {
        }

        private int _msg_type = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"msg_type",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int msg_type
        {
            get
            {
                return this._msg_type;
            }
            set
            {
                this._msg_type = value;
            }
        }

        private byte[] _msg_data = null;

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"msg_data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] msg_data
        {
            get
            {
                return this._msg_data;
            }
            set
            {
                this._msg_data = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsgList_UserMessages")]
    public partial class CSVCMsgList_UserMessages : global::ProtoBuf.IExtensible
    {
        public CSVCMsgList_UserMessages()
        {
        }

        private readonly global::System.Collections.Generic.List<CSVCMsgList_UserMessages.usermsg_t> _usermsgs =
            new global::System.Collections.Generic.List<CSVCMsgList_UserMessages.usermsg_t>();

        [global::ProtoBuf.ProtoMember(1, Name = @"usermsgs", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CSVCMsgList_UserMessages.usermsg_t> usermsgs
        {
            get
            {
                return this._usermsgs;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"usermsg_t")]
        public partial class usermsg_t : global::ProtoBuf.IExtensible
        {
            public usermsg_t()
            {
            }

            private int _tick = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"tick",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int tick
            {
                get
                {
                    return this._tick;
                }
                set
                {
                    this._tick = value;
                }
            }

            private CSVCMsg_UserMessage _msg = null;

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"msg",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public CSVCMsg_UserMessage msg
            {
                get
                {
                    return this._msg;
                }
                set
                {
                    this._msg = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CMsg_CVars")]
    public partial class CMsg_CVars : global::ProtoBuf.IExtensible
    {
        public CMsg_CVars()
        {
        }

        private readonly global::System.Collections.Generic.List<CMsg_CVars.CVar> _cvars =
            new global::System.Collections.Generic.List<CMsg_CVars.CVar>();

        [global::ProtoBuf.ProtoMember(1, Name = @"cvars", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CMsg_CVars.CVar> cvars
        {
            get
            {
                return this._cvars;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"CVar")]
        public partial class CVar : global::ProtoBuf.IExtensible
        {
            public CVar()
            {
            }

            private string _name = "";

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get
                {
                    return this._name;
                }
                set
                {
                    this._name = value;
                }
            }

            private string _value = "";

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string value
            {
                get
                {
                    return this._value;
                }
                set
                {
                    this._value = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_NOP")]
    public partial class CNETMsg_NOP : global::ProtoBuf.IExtensible
    {
        public CNETMsg_NOP()
        {
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_Disconnect")]
    public partial class CNETMsg_Disconnect : global::ProtoBuf.IExtensible
    {
        public CNETMsg_Disconnect()
        {
        }

        private string _text = "";

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"text",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_File")]
    public partial class CNETMsg_File : global::ProtoBuf.IExtensible
    {
        public CNETMsg_File()
        {
        }

        private int _transfer_id = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"transfer_id",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int transfer_id
        {
            get
            {
                return this._transfer_id;
            }
            set
            {
                this._transfer_id = value;
            }
        }

        private string _file_name = "";

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"file_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string file_name
        {
            get
            {
                return this._file_name;
            }
            set
            {
                this._file_name = value;
            }
        }

        private bool _is_replay_demo_file = default(bool);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"is_replay_demo_file",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_replay_demo_file
        {
            get
            {
                return this._is_replay_demo_file;
            }
            set
            {
                this._is_replay_demo_file = value;
            }
        }

        private bool _deny = default(bool);

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"deny",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool deny
        {
            get
            {
                return this._deny;
            }
            set
            {
                this._deny = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_SplitScreenUser")]
    public partial class CNETMsg_SplitScreenUser : global::ProtoBuf.IExtensible
    {
        public CNETMsg_SplitScreenUser()
        {
        }

        private int _slot = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"slot",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int slot
        {
            get
            {
                return this._slot;
            }
            set
            {
                this._slot = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_Tick")]
    public partial class CNETMsg_Tick : global::ProtoBuf.IExtensible
    {
        public CNETMsg_Tick()
        {
        }

        private uint _tick = default(uint);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"tick",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint tick
        {
            get
            {
                return this._tick;
            }
            set
            {
                this._tick = value;
            }
        }

        private uint _host_frametime = default(uint);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"host_frametime",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint host_frametime
        {
            get
            {
                return this._host_frametime;
            }
            set
            {
                this._host_frametime = value;
            }
        }

        private uint _host_frametime_std_deviation = default(uint);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"host_frametime_std_deviation",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint host_frametime_std_deviation
        {
            get
            {
                return this._host_frametime_std_deviation;
            }
            set
            {
                this._host_frametime_std_deviation = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_StringCmd")]
    public partial class CNETMsg_StringCmd : global::ProtoBuf.IExtensible
    {
        public CNETMsg_StringCmd()
        {
        }

        private string _command = "";

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"command",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string command
        {
            get
            {
                return this._command;
            }
            set
            {
                this._command = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_SetConVar")]
    public partial class CNETMsg_SetConVar : global::ProtoBuf.IExtensible
    {
        public CNETMsg_SetConVar()
        {
        }

        private CMsg_CVars _convars = null;

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"convars",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsg_CVars convars
        {
            get
            {
                return this._convars;
            }
            set
            {
                this._convars = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CNETMsg_SignonState")]
    public partial class CNETMsg_SignonState : global::ProtoBuf.IExtensible
    {
        public CNETMsg_SignonState()
        {
        }

        private uint _signon_state = default(uint);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"signon_state",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint signon_state
        {
            get
            {
                return this._signon_state;
            }
            set
            {
                this._signon_state = value;
            }
        }

        private uint _spawn_count = default(uint);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"spawn_count",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint spawn_count
        {
            get
            {
                return this._spawn_count;
            }
            set
            {
                this._spawn_count = value;
            }
        }

        private uint _num_server_players = default(uint);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"num_server_players",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint num_server_players
        {
            get
            {
                return this._num_server_players;
            }
            set
            {
                this._num_server_players = value;
            }
        }

        private readonly global::System.Collections.Generic.List<string> _players_networkids =
            new global::System.Collections.Generic.List<string>();

        [global::ProtoBuf.ProtoMember(4, Name = @"players_networkids", DataFormat = global::ProtoBuf.DataFormat.Default)
        ]
        public global::System.Collections.Generic.List<string> players_networkids
        {
            get
            {
                return this._players_networkids;
            }
        }

        private string _map_name = "";

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"map_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string map_name
        {
            get
            {
                return this._map_name;
            }
            set
            {
                this._map_name = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_ClientInfo")]
    public partial class CCLCMsg_ClientInfo : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_ClientInfo()
        {
        }

        private uint _send_table_crc = default(uint);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"send_table_crc",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint send_table_crc
        {
            get
            {
                return this._send_table_crc;
            }
            set
            {
                this._send_table_crc = value;
            }
        }

        private uint _server_count = default(uint);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"server_count",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint server_count
        {
            get
            {
                return this._server_count;
            }
            set
            {
                this._server_count = value;
            }
        }

        private bool _is_hltv = default(bool);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"is_hltv",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_hltv
        {
            get
            {
                return this._is_hltv;
            }
            set
            {
                this._is_hltv = value;
            }
        }

        private bool _is_replay = default(bool);

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"is_replay",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_replay
        {
            get
            {
                return this._is_replay;
            }
            set
            {
                this._is_replay = value;
            }
        }

        private uint _friends_id = default(uint);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"friends_id",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint friends_id
        {
            get
            {
                return this._friends_id;
            }
            set
            {
                this._friends_id = value;
            }
        }

        private string _friends_name = "";

        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"friends_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string friends_name
        {
            get
            {
                return this._friends_name;
            }
            set
            {
                this._friends_name = value;
            }
        }

        private readonly global::System.Collections.Generic.List<uint> _custom_files =
            new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(7, Name = @"custom_files", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public global::System.Collections.Generic.List<uint> custom_files
        {
            get
            {
                return this._custom_files;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_Move")]
    public partial class CCLCMsg_Move : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_Move()
        {
        }

        private uint _num_backup_commands = default(uint);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"num_backup_commands",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint num_backup_commands
        {
            get
            {
                return this._num_backup_commands;
            }
            set
            {
                this._num_backup_commands = value;
            }
        }

        private uint _num_new_commands = default(uint);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"num_new_commands",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint num_new_commands
        {
            get
            {
                return this._num_new_commands;
            }
            set
            {
                this._num_new_commands = value;
            }
        }

        private byte[] _data = null;

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_VoiceData")]
    public partial class CCLCMsg_VoiceData : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_VoiceData()
        {
        }

        private byte[] _data = null;

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }

        private ulong _xuid = default(ulong);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"xuid",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong xuid
        {
            get
            {
                return this._xuid;
            }
            set
            {
                this._xuid = value;
            }
        }

        private VoiceDataFormat_t _format = VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM;

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"format",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM)]
        public VoiceDataFormat_t format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_BaselineAck")]
    public partial class CCLCMsg_BaselineAck : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_BaselineAck()
        {
        }

        private int _baseline_tick = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"baseline_tick",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int baseline_tick
        {
            get
            {
                return this._baseline_tick;
            }
            set
            {
                this._baseline_tick = value;
            }
        }

        private int _baseline_nr = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"baseline_nr",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int baseline_nr
        {
            get
            {
                return this._baseline_nr;
            }
            set
            {
                this._baseline_nr = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_ListenEvents")]
    public partial class CCLCMsg_ListenEvents : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_ListenEvents()
        {
        }

        private readonly global::System.Collections.Generic.List<uint> _event_mask =
            new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(1, Name = @"event_mask", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public global::System.Collections.Generic.List<uint> event_mask
        {
            get
            {
                return this._event_mask;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_RespondCvarValue")]
    public partial class CCLCMsg_RespondCvarValue : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_RespondCvarValue()
        {
        }

        private int _cookie = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"cookie",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int cookie
        {
            get
            {
                return this._cookie;
            }
            set
            {
                this._cookie = value;
            }
        }

        private int _status_code = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"status_code",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int status_code
        {
            get
            {
                return this._status_code;
            }
            set
            {
                this._status_code = value;
            }
        }

        private string _name = "";

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        private string _value = "";

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"value",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_FileCRCCheck")]
    public partial class CCLCMsg_FileCRCCheck : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_FileCRCCheck()
        {
        }

        private int _code_path = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"code_path",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int code_path
        {
            get
            {
                return this._code_path;
            }
            set
            {
                this._code_path = value;
            }
        }

        private string _path = "";

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"path",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string path
        {
            get
            {
                return this._path;
            }
            set
            {
                this._path = value;
            }
        }

        private int _code_filename = default(int);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"code_filename",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int code_filename
        {
            get
            {
                return this._code_filename;
            }
            set
            {
                this._code_filename = value;
            }
        }

        private string _filename = "";

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"filename",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string filename
        {
            get
            {
                return this._filename;
            }
            set
            {
                this._filename = value;
            }
        }

        private uint _crc = default(uint);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"crc",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint crc
        {
            get
            {
                return this._crc;
            }
            set
            {
                this._crc = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_LoadingProgress")]
    public partial class CCLCMsg_LoadingProgress : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_LoadingProgress()
        {
        }

        private int _progress = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"progress",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int progress
        {
            get
            {
                return this._progress;
            }
            set
            {
                this._progress = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_SplitPlayerConnect")]
    public partial class CCLCMsg_SplitPlayerConnect : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_SplitPlayerConnect()
        {
        }

        private CMsg_CVars _convars = null;

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"convars",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsg_CVars convars
        {
            get
            {
                return this._convars;
            }
            set
            {
                this._convars = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CCLCMsg_ClientMessage")]
    public partial class CCLCMsg_ClientMessage : global::ProtoBuf.IExtensible
    {
        public CCLCMsg_ClientMessage()
        {
        }

        private int _msg_type = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"msg_type",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int msg_type
        {
            get
            {
                return this._msg_type;
            }
            set
            {
                this._msg_type = value;
            }
        }

        private byte[] _data = null;

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_ServerInfo")]
    public partial class CSVCMsg_ServerInfo : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_ServerInfo()
        {
        }

        private int _protocol = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"protocol",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int protocol
        {
            get
            {
                return this._protocol;
            }
            set
            {
                this._protocol = value;
            }
        }

        private int _server_count = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"server_count",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int server_count
        {
            get
            {
                return this._server_count;
            }
            set
            {
                this._server_count = value;
            }
        }

        private bool _is_dedicated = default(bool);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"is_dedicated",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_dedicated
        {
            get
            {
                return this._is_dedicated;
            }
            set
            {
                this._is_dedicated = value;
            }
        }

        private bool _is_hltv = default(bool);

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"is_hltv",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_hltv
        {
            get
            {
                return this._is_hltv;
            }
            set
            {
                this._is_hltv = value;
            }
        }

        private bool _is_replay = default(bool);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"is_replay",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_replay
        {
            get
            {
                return this._is_replay;
            }
            set
            {
                this._is_replay = value;
            }
        }

        private int _c_os = default(int);

        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"c_os",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int c_os
        {
            get
            {
                return this._c_os;
            }
            set
            {
                this._c_os = value;
            }
        }

        private uint _map_crc = default(uint);

        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"map_crc",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint map_crc
        {
            get
            {
                return this._map_crc;
            }
            set
            {
                this._map_crc = value;
            }
        }

        private uint _client_crc = default(uint);

        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"client_crc",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint client_crc
        {
            get
            {
                return this._client_crc;
            }
            set
            {
                this._client_crc = value;
            }
        }

        private uint _string_table_crc = default(uint);

        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"string_table_crc",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint string_table_crc
        {
            get
            {
                return this._string_table_crc;
            }
            set
            {
                this._string_table_crc = value;
            }
        }

        private int _max_clients = default(int);

        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"max_clients",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int max_clients
        {
            get
            {
                return this._max_clients;
            }
            set
            {
                this._max_clients = value;
            }
        }

        private int _max_classes = default(int);

        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"max_classes",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int max_classes
        {
            get
            {
                return this._max_classes;
            }
            set
            {
                this._max_classes = value;
            }
        }

        private int _player_slot = default(int);

        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name = @"player_slot",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player_slot
        {
            get
            {
                return this._player_slot;
            }
            set
            {
                this._player_slot = value;
            }
        }

        private float _tick_interval = default(float);

        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name = @"tick_interval",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float tick_interval
        {
            get
            {
                return this._tick_interval;
            }
            set
            {
                this._tick_interval = value;
            }
        }

        private string _game_dir = "";

        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"game_dir",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string game_dir
        {
            get
            {
                return this._game_dir;
            }
            set
            {
                this._game_dir = value;
            }
        }

        private string _map_name = "";

        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name = @"map_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string map_name
        {
            get
            {
                return this._map_name;
            }
            set
            {
                this._map_name = value;
            }
        }

        private string _sky_name = "";

        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name = @"sky_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sky_name
        {
            get
            {
                return this._sky_name;
            }
            set
            {
                this._sky_name = value;
            }
        }

        private string _host_name = "";

        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name = @"host_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string host_name
        {
            get
            {
                return this._host_name;
            }
            set
            {
                this._host_name = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_ClassInfo")]
    public partial class CSVCMsg_ClassInfo : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_ClassInfo()
        {
        }

        private bool _create_on_client = default(bool);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"create_on_client",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool create_on_client
        {
            get
            {
                return this._create_on_client;
            }
            set
            {
                this._create_on_client = value;
            }
        }

        private readonly global::System.Collections.Generic.List<CSVCMsg_ClassInfo.class_t> _classes =
            new global::System.Collections.Generic.List<CSVCMsg_ClassInfo.class_t>();

        [global::ProtoBuf.ProtoMember(2, Name = @"classes", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CSVCMsg_ClassInfo.class_t> classes
        {
            get
            {
                return this._classes;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"class_t")]
        public partial class class_t : global::ProtoBuf.IExtensible
        {
            public class_t()
            {
            }

            private int _class_id = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"class_id",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int class_id
            {
                get
                {
                    return this._class_id;
                }
                set
                {
                    this._class_id = value;
                }
            }

            private string _data_table_name = "";

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"data_table_name",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string data_table_name
            {
                get
                {
                    return this._data_table_name;
                }
                set
                {
                    this._data_table_name = value;
                }
            }

            private string _class_name = "";

            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"class_name",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string class_name
            {
                get
                {
                    return this._class_name;
                }
                set
                {
                    this._class_name = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_SetPause")]
    public partial class CSVCMsg_SetPause : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_SetPause()
        {
        }

        private bool _paused = default(bool);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"paused",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool paused
        {
            get
            {
                return this._paused;
            }
            set
            {
                this._paused = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_VoiceInit")]
    public partial class CSVCMsg_VoiceInit : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_VoiceInit()
        {
        }

        private int _quality = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"quality",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int quality
        {
            get
            {
                return this._quality;
            }
            set
            {
                this._quality = value;
            }
        }

        private string _codec = "";

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"codec",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string codec
        {
            get
            {
                return this._codec;
            }
            set
            {
                this._codec = value;
            }
        }

        private int _version = (int)0;

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"version",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue((int)0)]
        public int version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_Print")]
    public partial class CSVCMsg_Print : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_Print()
        {
        }

        private string _text = "";

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"text",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_Sounds")]
    public partial class CSVCMsg_Sounds : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_Sounds()
        {
        }

        private bool _reliable_sound = default(bool);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"reliable_sound",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool reliable_sound
        {
            get
            {
                return this._reliable_sound;
            }
            set
            {
                this._reliable_sound = value;
            }
        }

        private readonly global::System.Collections.Generic.List<CSVCMsg_Sounds.sounddata_t> _sounds =
            new global::System.Collections.Generic.List<CSVCMsg_Sounds.sounddata_t>();

        [global::ProtoBuf.ProtoMember(2, Name = @"sounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CSVCMsg_Sounds.sounddata_t> sounds
        {
            get
            {
                return this._sounds;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"sounddata_t")]
        public partial class sounddata_t : global::ProtoBuf.IExtensible
        {
            public sounddata_t()
            {
            }

            private int _origin_x = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"origin_x",
                DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int origin_x
            {
                get
                {
                    return this._origin_x;
                }
                set
                {
                    this._origin_x = value;
                }
            }

            private int _origin_y = default(int);

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"origin_y",
                DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int origin_y
            {
                get
                {
                    return this._origin_y;
                }
                set
                {
                    this._origin_y = value;
                }
            }

            private int _origin_z = default(int);

            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"origin_z",
                DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int origin_z
            {
                get
                {
                    return this._origin_z;
                }
                set
                {
                    this._origin_z = value;
                }
            }

            private uint _volume = default(uint);

            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"volume",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint volume
            {
                get
                {
                    return this._volume;
                }
                set
                {
                    this._volume = value;
                }
            }

            private float _delay_value = default(float);

            [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"delay_value",
                DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue(default(float))]
            public float delay_value
            {
                get
                {
                    return this._delay_value;
                }
                set
                {
                    this._delay_value = value;
                }
            }

            private int _sequence_number = default(int);

            [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"sequence_number",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int sequence_number
            {
                get
                {
                    return this._sequence_number;
                }
                set
                {
                    this._sequence_number = value;
                }
            }

            private int _entity_index = default(int);

            [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"entity_index",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int entity_index
            {
                get
                {
                    return this._entity_index;
                }
                set
                {
                    this._entity_index = value;
                }
            }

            private int _channel = default(int);

            [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"channel",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int channel
            {
                get
                {
                    return this._channel;
                }
                set
                {
                    this._channel = value;
                }
            }

            private int _pitch = default(int);

            [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"pitch",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int pitch
            {
                get
                {
                    return this._pitch;
                }
                set
                {
                    this._pitch = value;
                }
            }

            private int _flags = default(int);

            [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"flags",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int flags
            {
                get
                {
                    return this._flags;
                }
                set
                {
                    this._flags = value;
                }
            }

            private uint _sound_num = default(uint);

            [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"sound_num",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint sound_num
            {
                get
                {
                    return this._sound_num;
                }
                set
                {
                    this._sound_num = value;
                }
            }

            private uint _sound_num_handle = default(uint);

            [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name = @"sound_num_handle",
                DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint sound_num_handle
            {
                get
                {
                    return this._sound_num_handle;
                }
                set
                {
                    this._sound_num_handle = value;
                }
            }

            private int _speaker_entity = default(int);

            [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name = @"speaker_entity",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int speaker_entity
            {
                get
                {
                    return this._speaker_entity;
                }
                set
                {
                    this._speaker_entity = value;
                }
            }

            private int _random_seed = default(int);

            [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"random_seed",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int random_seed
            {
                get
                {
                    return this._random_seed;
                }
                set
                {
                    this._random_seed = value;
                }
            }

            private int _sound_level = default(int);

            [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name = @"sound_level",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int sound_level
            {
                get
                {
                    return this._sound_level;
                }
                set
                {
                    this._sound_level = value;
                }
            }

            private bool _is_sentence = default(bool);

            [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name = @"is_sentence",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(default(bool))]
            public bool is_sentence
            {
                get
                {
                    return this._is_sentence;
                }
                set
                {
                    this._is_sentence = value;
                }
            }

            private bool _is_ambient = default(bool);

            [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name = @"is_ambient",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(default(bool))]
            public bool is_ambient
            {
                get
                {
                    return this._is_ambient;
                }
                set
                {
                    this._is_ambient = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_Prefetch")]
    public partial class CSVCMsg_Prefetch : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_Prefetch()
        {
        }

        private int _sound_index = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"sound_index",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int sound_index
        {
            get
            {
                return this._sound_index;
            }
            set
            {
                this._sound_index = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_SetView")]
    public partial class CSVCMsg_SetView : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_SetView()
        {
        }

        private int _entity_index = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"entity_index",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entity_index
        {
            get
            {
                return this._entity_index;
            }
            set
            {
                this._entity_index = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_FixAngle")]
    public partial class CSVCMsg_FixAngle : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_FixAngle()
        {
        }

        private bool _relative = default(bool);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"relative",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool relative
        {
            get
            {
                return this._relative;
            }
            set
            {
                this._relative = value;
            }
        }

        private CMsgQAngle _angle = null;

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"angle",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgQAngle angle
        {
            get
            {
                return this._angle;
            }
            set
            {
                this._angle = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_CrosshairAngle")]
    public partial class CSVCMsg_CrosshairAngle : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_CrosshairAngle()
        {
        }

        private CMsgQAngle _angle = null;

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"angle",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgQAngle angle
        {
            get
            {
                return this._angle;
            }
            set
            {
                this._angle = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_BSPDecal")]
    public partial class CSVCMsg_BSPDecal : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_BSPDecal()
        {
        }

        private CMsgVector _pos = null;

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"pos",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsgVector pos
        {
            get
            {
                return this._pos;
            }
            set
            {
                this._pos = value;
            }
        }

        private int _decal_texture_index = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"decal_texture_index",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int decal_texture_index
        {
            get
            {
                return this._decal_texture_index;
            }
            set
            {
                this._decal_texture_index = value;
            }
        }

        private int _entity_index = default(int);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"entity_index",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int entity_index
        {
            get
            {
                return this._entity_index;
            }
            set
            {
                this._entity_index = value;
            }
        }

        private int _model_index = default(int);

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"model_index",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int model_index
        {
            get
            {
                return this._model_index;
            }
            set
            {
                this._model_index = value;
            }
        }

        private bool _low_priority = default(bool);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"low_priority",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool low_priority
        {
            get
            {
                return this._low_priority;
            }
            set
            {
                this._low_priority = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_SplitScreen")]
    public partial class CSVCMsg_SplitScreen : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_SplitScreen()
        {
        }

        private ESplitScreenMessageType _type = ESplitScreenMessageType.MSG_SPLITSCREEN_ADDUSER;

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"type",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(ESplitScreenMessageType.MSG_SPLITSCREEN_ADDUSER)]
        public ESplitScreenMessageType type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        private int _slot = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"slot",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int slot
        {
            get
            {
                return this._slot;
            }
            set
            {
                this._slot = value;
            }
        }

        private int _player_index = default(int);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"player_index",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player_index
        {
            get
            {
                return this._player_index;
            }
            set
            {
                this._player_index = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_GetCvarValue")]
    public partial class CSVCMsg_GetCvarValue : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_GetCvarValue()
        {
        }

        private int _cookie = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"cookie",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int cookie
        {
            get
            {
                return this._cookie;
            }
            set
            {
                this._cookie = value;
            }
        }

        private string _cvar_name = "";

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"cvar_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string cvar_name
        {
            get
            {
                return this._cvar_name;
            }
            set
            {
                this._cvar_name = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_Menu")]
    public partial class CSVCMsg_Menu : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_Menu()
        {
        }

        private int _dialog_type = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"dialog_type",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int dialog_type
        {
            get
            {
                return this._dialog_type;
            }
            set
            {
                this._dialog_type = value;
            }
        }

        private byte[] _menu_key_values = null;

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"menu_key_values",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] menu_key_values
        {
            get
            {
                return this._menu_key_values;
            }
            set
            {
                this._menu_key_values = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_SendTable")]
    public partial class CSVCMsg_SendTable : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_SendTable()
        {
        }

        private bool _is_end = default(bool);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"is_end",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_end
        {
            get
            {
                return this._is_end;
            }
            set
            {
                this._is_end = value;
            }
        }

        private string _net_table_name = "";

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"net_table_name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string net_table_name
        {
            get
            {
                return this._net_table_name;
            }
            set
            {
                this._net_table_name = value;
            }
        }

        private bool _needs_decoder = default(bool);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"needs_decoder",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool needs_decoder
        {
            get
            {
                return this._needs_decoder;
            }
            set
            {
                this._needs_decoder = value;
            }
        }

        private readonly global::System.Collections.Generic.List<CSVCMsg_SendTable.sendprop_t> _props =
            new global::System.Collections.Generic.List<CSVCMsg_SendTable.sendprop_t>();

        [global::ProtoBuf.ProtoMember(4, Name = @"props", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CSVCMsg_SendTable.sendprop_t> props
        {
            get
            {
                return this._props;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"sendprop_t")]
        public partial class sendprop_t : global::ProtoBuf.IExtensible
        {
            public sendprop_t()
            {
            }

            private int _type = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"type",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int type
            {
                get
                {
                    return this._type;
                }
                set
                {
                    this._type = value;
                }
            }

            private string _var_name = "";

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"var_name",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string var_name
            {
                get
                {
                    return this._var_name;
                }
                set
                {
                    this._var_name = value;
                }
            }

            private int _flags = default(int);

            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"flags",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int flags
            {
                get
                {
                    return this._flags;
                }
                set
                {
                    this._flags = value;
                }
            }

            private int _priority = default(int);

            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"priority",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int priority
            {
                get
                {
                    return this._priority;
                }
                set
                {
                    this._priority = value;
                }
            }

            private string _dt_name = "";

            [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"dt_name",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string dt_name
            {
                get
                {
                    return this._dt_name;
                }
                set
                {
                    this._dt_name = value;
                }
            }

            private int _num_elements = default(int);

            [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"num_elements",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int num_elements
            {
                get
                {
                    return this._num_elements;
                }
                set
                {
                    this._num_elements = value;
                }
            }

            private float _low_value = default(float);

            [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"low_value",
                DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue(default(float))]
            public float low_value
            {
                get
                {
                    return this._low_value;
                }
                set
                {
                    this._low_value = value;
                }
            }

            private float _high_value = default(float);

            [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"high_value",
                DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
            [global::System.ComponentModel.DefaultValue(default(float))]
            public float high_value
            {
                get
                {
                    return this._high_value;
                }
                set
                {
                    this._high_value = value;
                }
            }

            private int _num_bits = default(int);

            [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"num_bits",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int num_bits
            {
                get
                {
                    return this._num_bits;
                }
                set
                {
                    this._num_bits = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_GameEventList")]
    public partial class CSVCMsg_GameEventList : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_GameEventList()
        {
        }

        private readonly global::System.Collections.Generic.List<CSVCMsg_GameEventList.descriptor_t> _descriptors =
            new global::System.Collections.Generic.List<CSVCMsg_GameEventList.descriptor_t>();

        [global::ProtoBuf.ProtoMember(1, Name = @"descriptors", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CSVCMsg_GameEventList.descriptor_t> descriptors
        {
            get
            {
                return this._descriptors;
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"key_t")]
        public partial class key_t : global::ProtoBuf.IExtensible
        {
            public key_t()
            {
            }

            private int _type = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"type",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int type
            {
                get
                {
                    return this._type;
                }
                set
                {
                    this._type = value;
                }
            }

            private string _name = "";

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"name",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get
                {
                    return this._name;
                }
                set
                {
                    this._name = value;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        [global::System.Serializable]
        [global::ProtoBuf.ProtoContract(Name = @"descriptor_t")]
        public partial class descriptor_t : global::ProtoBuf.IExtensible
        {
            public descriptor_t()
            {
            }

            private int _eventid = default(int);

            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"eventid",
                DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int eventid
            {
                get
                {
                    return this._eventid;
                }
                set
                {
                    this._eventid = value;
                }
            }

            private string _name = "";

            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"name",
                DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get
                {
                    return this._name;
                }
                set
                {
                    this._name = value;
                }
            }

            private readonly global::System.Collections.Generic.List<CSVCMsg_GameEventList.key_t> _keys =
                new global::System.Collections.Generic.List<CSVCMsg_GameEventList.key_t>();

            [global::ProtoBuf.ProtoMember(3, Name = @"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
            public global::System.Collections.Generic.List<CSVCMsg_GameEventList.key_t> keys
            {
                get
                {
                    return this._keys;
                }
            }

            private global::ProtoBuf.IExtension extensionObject;

            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_PacketEntities")]
    public partial class CSVCMsg_PacketEntities : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_PacketEntities()
        {
        }

        private int _max_entries = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"max_entries",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int max_entries
        {
            get
            {
                return this._max_entries;
            }
            set
            {
                this._max_entries = value;
            }
        }

        private int _updated_entries = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"updated_entries",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int updated_entries
        {
            get
            {
                return this._updated_entries;
            }
            set
            {
                this._updated_entries = value;
            }
        }

        private bool _is_delta = default(bool);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"is_delta",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_delta
        {
            get
            {
                return this._is_delta;
            }
            set
            {
                this._is_delta = value;
            }
        }

        private bool _update_baseline = default(bool);

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"update_baseline",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool update_baseline
        {
            get
            {
                return this._update_baseline;
            }
            set
            {
                this._update_baseline = value;
            }
        }

        private int _baseline = default(int);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"baseline",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int baseline
        {
            get
            {
                return this._baseline;
            }
            set
            {
                this._baseline = value;
            }
        }

        private int _delta_from = default(int);

        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"delta_from",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int delta_from
        {
            get
            {
                return this._delta_from;
            }
            set
            {
                this._delta_from = value;
            }
        }

        private byte[] _entity_data = null;

        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"entity_data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] entity_data
        {
            get
            {
                return this._entity_data;
            }
            set
            {
                this._entity_data = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_TempEntities")]
    public partial class CSVCMsg_TempEntities : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_TempEntities()
        {
        }

        private bool _reliable = default(bool);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"reliable",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool reliable
        {
            get
            {
                return this._reliable;
            }
            set
            {
                this._reliable = value;
            }
        }

        private int _num_entries = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"num_entries",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int num_entries
        {
            get
            {
                return this._num_entries;
            }
            set
            {
                this._num_entries = value;
            }
        }

        private byte[] _entity_data = null;

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"entity_data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] entity_data
        {
            get
            {
                return this._entity_data;
            }
            set
            {
                this._entity_data = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_CreateStringTable")]
    public partial class CSVCMsg_CreateStringTable : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_CreateStringTable()
        {
        }

        private string _name = "";

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        private int _max_entries = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"max_entries",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int max_entries
        {
            get
            {
                return this._max_entries;
            }
            set
            {
                this._max_entries = value;
            }
        }

        private int _num_entries = default(int);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"num_entries",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int num_entries
        {
            get
            {
                return this._num_entries;
            }
            set
            {
                this._num_entries = value;
            }
        }

        private bool _user_data_fixed_size = default(bool);

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"user_data_fixed_size",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool user_data_fixed_size
        {
            get
            {
                return this._user_data_fixed_size;
            }
            set
            {
                this._user_data_fixed_size = value;
            }
        }

        private int _user_data_size = default(int);

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"user_data_size",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int user_data_size
        {
            get
            {
                return this._user_data_size;
            }
            set
            {
                this._user_data_size = value;
            }
        }

        private int _user_data_size_bits = default(int);

        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"user_data_size_bits",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int user_data_size_bits
        {
            get
            {
                return this._user_data_size_bits;
            }
            set
            {
                this._user_data_size_bits = value;
            }
        }

        private int _flags = default(int);

        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"flags",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int flags
        {
            get
            {
                return this._flags;
            }
            set
            {
                this._flags = value;
            }
        }

        private byte[] _string_data = null;

        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"string_data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] string_data
        {
            get
            {
                return this._string_data;
            }
            set
            {
                this._string_data = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_UpdateStringTable")]
    public partial class CSVCMsg_UpdateStringTable : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_UpdateStringTable()
        {
        }

        private int _table_id = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"table_id",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int table_id
        {
            get
            {
                return this._table_id;
            }
            set
            {
                this._table_id = value;
            }
        }

        private int _num_changed_entries = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"num_changed_entries",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int num_changed_entries
        {
            get
            {
                return this._num_changed_entries;
            }
            set
            {
                this._num_changed_entries = value;
            }
        }

        private byte[] _string_data = null;

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"string_data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] string_data
        {
            get
            {
                return this._string_data;
            }
            set
            {
                this._string_data = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_VoiceData")]
    public partial class CSVCMsg_VoiceData : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_VoiceData()
        {
        }

        private int _client = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"client",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int client
        {
            get
            {
                return this._client;
            }
            set
            {
                this._client = value;
            }
        }

        private bool _proximity = default(bool);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"proximity",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool proximity
        {
            get
            {
                return this._proximity;
            }
            set
            {
                this._proximity = value;
            }
        }

        private ulong _xuid = default(ulong);

        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"xuid",
            DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(ulong))]
        public ulong xuid
        {
            get
            {
                return this._xuid;
            }
            set
            {
                this._xuid = value;
            }
        }

        private int _audible_mask = default(int);

        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"audible_mask",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int audible_mask
        {
            get
            {
                return this._audible_mask;
            }
            set
            {
                this._audible_mask = value;
            }
        }

        private byte[] _voice_data = null;

        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"voice_data",
            DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] voice_data
        {
            get
            {
                return this._voice_data;
            }
            set
            {
                this._voice_data = value;
            }
        }

        private VoiceDataFormat_t _format = VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM;

        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"format",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(VoiceDataFormat_t.VOICEDATA_FORMAT_STEAM)]
        public VoiceDataFormat_t format
        {
            get
            {
                return this._format;
            }
            set
            {
                this._format = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::System.Serializable]
    [global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_PacketReliable")]
    public partial class CSVCMsg_PacketReliable : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_PacketReliable()
        {
        }

        private int _tick = default(int);

        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"tick",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int tick
        {
            get
            {
                return this._tick;
            }
            set
            {
                this._tick = value;
            }
        }

        private int _messagessize = default(int);

        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"messagessize",
            DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int messagessize
        {
            get
            {
                return this._messagessize;
            }
            set
            {
                this._messagessize = value;
            }
        }

        private global::ProtoBuf.IExtension extensionObject;

        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }
    }

    [global::ProtoBuf.ProtoContract(Name = @"SIGNONSTATE")]
    public enum SIGNONSTATE
    {

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_NONE", Value = 0)]
        SIGNONSTATE_NONE = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_CHALLENGE", Value = 1)]
        SIGNONSTATE_CHALLENGE = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_CONNECTED", Value = 2)]
        SIGNONSTATE_CONNECTED = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_NEW", Value = 3)]
        SIGNONSTATE_NEW = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_PRESPAWN", Value = 4)]
        SIGNONSTATE_PRESPAWN = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_SPAWN", Value = 5)]
        SIGNONSTATE_SPAWN = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_FULL", Value = 6)]
        SIGNONSTATE_FULL = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"SIGNONSTATE_CHANGELEVEL", Value = 7)]
        SIGNONSTATE_CHANGELEVEL = 7
    }

    [global::ProtoBuf.ProtoContract(Name = @"NET_Messages")]
    public enum NET_Messages_Kind
    {

        [global::ProtoBuf.ProtoEnum(Name = @"net_NOP", Value = 0)]
        net_NOP = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"net_Disconnect", Value = 1)]
        net_Disconnect = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"net_File", Value = 2)]
        net_File = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"net_SplitScreenUser", Value = 3)]
        net_SplitScreenUser = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"net_Tick", Value = 4)]
        net_Tick = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"net_StringCmd", Value = 5)]
        net_StringCmd = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"net_SetConVar", Value = 6)]
        net_SetConVar = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"net_SignonState", Value = 7)]
        net_SignonState = 7
    }

    [global::ProtoBuf.ProtoContract(Name = @"CLC_Messages")]
    public enum CLC_Messages
    {

        [global::ProtoBuf.ProtoEnum(Name = @"clc_ClientInfo", Value = 8)]
        clc_ClientInfo = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_Move", Value = 9)]
        clc_Move = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_VoiceData", Value = 10)]
        clc_VoiceData = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_BaselineAck", Value = 11)]
        clc_BaselineAck = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_ListenEvents", Value = 12)]
        clc_ListenEvents = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_RespondCvarValue", Value = 13)]
        clc_RespondCvarValue = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_FileCRCCheck", Value = 14)]
        clc_FileCRCCheck = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_LoadingProgress", Value = 15)]
        clc_LoadingProgress = 15,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_SplitPlayerConnect", Value = 16)]
        clc_SplitPlayerConnect = 16,

        [global::ProtoBuf.ProtoEnum(Name = @"clc_ClientMessage", Value = 17)]
        clc_ClientMessage = 17
    }

    [global::ProtoBuf.ProtoContract(Name = @"VoiceDataFormat_t")]
    public enum VoiceDataFormat_t
    {

        [global::ProtoBuf.ProtoEnum(Name = @"VOICEDATA_FORMAT_STEAM", Value = 0)]
        VOICEDATA_FORMAT_STEAM = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"VOICEDATA_FORMAT_ENGINE", Value = 1)]
        VOICEDATA_FORMAT_ENGINE = 1
    }

    [global::ProtoBuf.ProtoContract(Name = @"SVC_Messages")]
    public enum SVC_Messages_Kind
    {

        [global::ProtoBuf.ProtoEnum(Name = @"svc_ServerInfo", Value = 8)]
        svc_ServerInfo = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_SendTable", Value = 9)]
        svc_SendTable = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_ClassInfo", Value = 10)]
        svc_ClassInfo = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_SetPause", Value = 11)]
        svc_SetPause = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_CreateStringTable", Value = 12)]
        svc_CreateStringTable = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_UpdateStringTable", Value = 13)]
        svc_UpdateStringTable = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_VoiceInit", Value = 14)]
        svc_VoiceInit = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_VoiceData", Value = 15)]
        svc_VoiceData = 15,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_Print", Value = 16)]
        svc_Print = 16,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_Sounds", Value = 17)]
        svc_Sounds = 17,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_SetView", Value = 18)]
        svc_SetView = 18,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_FixAngle", Value = 19)]
        svc_FixAngle = 19,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_CrosshairAngle", Value = 20)]
        svc_CrosshairAngle = 20,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_BSPDecal", Value = 21)]
        svc_BSPDecal = 21,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_SplitScreen", Value = 22)]
        svc_SplitScreen = 22,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_UserMessage", Value = 23)]
        svc_UserMessage = 23,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_EntityMessage", Value = 24)]
        svc_EntityMessage = 24,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_GameEvent", Value = 25)]
        svc_GameEvent = 25,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_PacketEntities", Value = 26)]
        svc_PacketEntities = 26,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_TempEntities", Value = 27)]
        svc_TempEntities = 27,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_Prefetch", Value = 28)]
        svc_Prefetch = 28,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_Menu", Value = 29)]
        svc_Menu = 29,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_GameEventList", Value = 30)]
        svc_GameEventList = 30,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_GetCvarValue", Value = 31)]
        svc_GetCvarValue = 31,

        [global::ProtoBuf.ProtoEnum(Name = @"svc_PacketReliable", Value = 32)]
        svc_PacketReliable = 32
    }

    [global::ProtoBuf.ProtoContract(Name = @"ESplitScreenMessageType")]
    public enum ESplitScreenMessageType
    {

        [global::ProtoBuf.ProtoEnum(Name = @"MSG_SPLITSCREEN_ADDUSER", Value = 0)]
        MSG_SPLITSCREEN_ADDUSER = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"MSG_SPLITSCREEN_REMOVEUSER", Value = 1)]
        MSG_SPLITSCREEN_REMOVEUSER = 1
    }
}