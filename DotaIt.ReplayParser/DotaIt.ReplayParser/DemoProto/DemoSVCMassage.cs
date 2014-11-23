namespace DotaIt.ReplayParser.DemoProto
{
    /// <summary>
    /// The demo server massage.
    /// </summary>
    public class DemoSVCMassage<T> : MessageBase
    {
        private SVCMessageKind _kind;

        private T _messageInstance;

        public SVCMessageKind Kind
        {
            get
            {
                return _kind;
            }
        }

        public T MessageInstance
        {
            get
            {
                return _messageInstance;
            }
        }

        public DemoSVCMassage(int kindValue, byte[] message)
            : base(kindValue, message)
        {
        }

        public override void BuildMessageInstance()
        {
            _messageInstance = Helper.DeserilizedFromBytes<T>(Message);
        }

        public static DemoSVCMassage<T> Create(int kind, byte[] message)
        {
            DemoSVCMassage<T> svcMessages = new DemoSVCMassage<T>(kind, message);
            svcMessages.BuildMessageInstance();
            return svcMessages;
        }

    }

    public enum SVCMessageKind
    {
        svc_ServerInfo = 8,

        svc_SendTable = 9,

        svc_ClassInfo = 10,

        svc_SetPause = 11,

        svc_CreateStringTable = 12,

        svc_UpdateStringTable = 13,

        svc_VoiceInit = 14,

        svc_VoiceData = 15,

        svc_Print = 16,

        svc_Sounds = 17,

        svc_SetView = 18,

        svc_FixAngle = 19,

        svc_CrosshairAngle = 20,

        svc_BSPDecal = 21,

        svc_SplitScreen = 22,

        svc_UserMessage = 23,

        svc_EntityMessage = 24,

        svc_GameEvent = 25,

        svc_PacketEntities = 26,

        svc_TempEntities = 27,

        svc_Prefetch = 28,

        svc_Menu = 29,

        svc_GameEventList = 30,

        svc_GetCvarValue = 31,

        svc_PacketReliable = 32,
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CSVCMsg_ServerInfo")]
    public partial class CSVCMsg_ServerInfo_Proto : global::ProtoBuf.IExtensible
    {
        public CSVCMsg_ServerInfo_Proto() { }

        private int _protocol = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"protocol", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int protocol
        {
            get { return _protocol; }
            set { _protocol = value; }
        }
        private int _server_count = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"server_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int server_count
        {
            get { return _server_count; }
            set { _server_count = value; }
        }
        private bool _is_dedicated = default(bool);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"is_dedicated", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_dedicated
        {
            get { return _is_dedicated; }
            set { _is_dedicated = value; }
        }
        private bool _is_hltv = default(bool);
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"is_hltv", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_hltv
        {
            get { return _is_hltv; }
            set { _is_hltv = value; }
        }
        private bool _is_replay = default(bool);
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"is_replay", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool is_replay
        {
            get { return _is_replay; }
            set { _is_replay = value; }
        }
        private int _c_os = default(int);
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"c_os", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int c_os
        {
            get { return _c_os; }
            set { _c_os = value; }
        }
        private uint _map_crc = default(uint);
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"map_crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint map_crc
        {
            get { return _map_crc; }
            set { _map_crc = value; }
        }
        private uint _client_crc = default(uint);
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"client_crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint client_crc
        {
            get { return _client_crc; }
            set { _client_crc = value; }
        }
        private uint _string_table_crc = default(uint);
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"string_table_crc", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(uint))]
        public uint string_table_crc
        {
            get { return _string_table_crc; }
            set { _string_table_crc = value; }
        }
        private int _max_clients = default(int);
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"max_clients", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int max_clients
        {
            get { return _max_clients; }
            set { _max_clients = value; }
        }
        private int _max_classes = default(int);
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"max_classes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int max_classes
        {
            get { return _max_classes; }
            set { _max_classes = value; }
        }
        private int _player_slot = default(int);
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name = @"player_slot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int player_slot
        {
            get { return _player_slot; }
            set { _player_slot = value; }
        }
        private float _tick_interval = default(float);
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name = @"tick_interval", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float tick_interval
        {
            get { return _tick_interval; }
            set { _tick_interval = value; }
        }
        private string _game_dir = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name = @"game_dir", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string game_dir
        {
            get { return _game_dir; }
            set { _game_dir = value; }
        }
        private string _map_name = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name = @"map_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string map_name
        {
            get { return _map_name; }
            set { _map_name = value; }
        }
        private string _sky_name = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name = @"sky_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sky_name
        {
            get { return _sky_name; }
            set { _sky_name = value; }
        }
        private string _host_name = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name = @"host_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string host_name
        {
            get { return _host_name; }
            set { _host_name = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}