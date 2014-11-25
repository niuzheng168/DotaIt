﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaIt.ReplayParser.DemoProto.ProtoDef
{

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoFileHeader")]
    public partial class CDemoFileHeader : global::ProtoBuf.IExtensible
    {
        public CDemoFileHeader() { }

        private string _demo_file_stamp;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name = @"demo_file_stamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string demo_file_stamp
        {
            get { return _demo_file_stamp; }
            set { _demo_file_stamp = value; }
        }
        private int _network_protocol = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"network_protocol", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int network_protocol
        {
            get { return _network_protocol; }
            set { _network_protocol = value; }
        }
        private string _server_name = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"server_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string server_name
        {
            get { return _server_name; }
            set { _server_name = value; }
        }
        private string _client_name = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"client_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string client_name
        {
            get { return _client_name; }
            set { _client_name = value; }
        }
        private string _map_name = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"map_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string map_name
        {
            get { return _map_name; }
            set { _map_name = value; }
        }
        private string _game_directory = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"game_directory", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string game_directory
        {
            get { return _game_directory; }
            set { _game_directory = value; }
        }
        private int _fullpackets_version = default(int);
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"fullpackets_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int fullpackets_version
        {
            get { return _fullpackets_version; }
            set { _fullpackets_version = value; }
        }
        private bool _allow_clientside_entities = default(bool);
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"allow_clientside_entities", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool allow_clientside_entities
        {
            get { return _allow_clientside_entities; }
            set { _allow_clientside_entities = value; }
        }
        private bool _allow_clientside_particles = default(bool);
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"allow_clientside_particles", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(default(bool))]
        public bool allow_clientside_particles
        {
            get { return _allow_clientside_particles; }
            set { _allow_clientside_particles = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CGameInfo")]
    public partial class CGameInfo : global::ProtoBuf.IExtensible
    {
        public CGameInfo() { }

        private CGameInfo.CDotaGameInfo _dota = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"dota", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CGameInfo.CDotaGameInfo dota
        {
            get { return _dota; }
            set { _dota = value; }
        }
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDotaGameInfo")]
        public partial class CDotaGameInfo : global::ProtoBuf.IExtensible
        {
            public CDotaGameInfo() { }

            private uint _match_id = default(uint);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"match_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint match_id
            {
                get { return _match_id; }
                set { _match_id = value; }
            }
            private int _game_mode = default(int);
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"game_mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int game_mode
            {
                get { return _game_mode; }
                set { _game_mode = value; }
            }
            private int _game_winner = default(int);
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"game_winner", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int game_winner
            {
                get { return _game_winner; }
                set { _game_winner = value; }
            }
            private readonly global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CPlayerInfo> _player_info = new global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CPlayerInfo>();
            [global::ProtoBuf.ProtoMember(4, Name = @"player_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
            public global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CPlayerInfo> player_info
            {
                get { return _player_info; }
            }

            private uint _leagueid = default(uint);
            [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"leagueid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint leagueid
            {
                get { return _leagueid; }
                set { _leagueid = value; }
            }
            private readonly global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CHeroSelectEvent> _picks_bans = new global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CHeroSelectEvent>();
            [global::ProtoBuf.ProtoMember(6, Name = @"picks_bans", DataFormat = global::ProtoBuf.DataFormat.Default)]
            public global::System.Collections.Generic.List<CGameInfo.CDotaGameInfo.CHeroSelectEvent> picks_bans
            {
                get { return _picks_bans; }
            }

            private uint _radiant_team_id = default(uint);
            [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"radiant_team_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint radiant_team_id
            {
                get { return _radiant_team_id; }
                set { _radiant_team_id = value; }
            }
            private uint _dire_team_id = default(uint);
            [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"dire_team_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint dire_team_id
            {
                get { return _dire_team_id; }
                set { _dire_team_id = value; }
            }
            private string _radiant_team_tag = "";
            [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"radiant_team_tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string radiant_team_tag
            {
                get { return _radiant_team_tag; }
                set { _radiant_team_tag = value; }
            }
            private string _dire_team_tag = "";
            [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"dire_team_tag", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string dire_team_tag
            {
                get { return _dire_team_tag; }
                set { _dire_team_tag = value; }
            }
            private uint _end_time = default(uint);
            [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name = @"end_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(uint))]
            public uint end_time
            {
                get { return _end_time; }
                set { _end_time = value; }
            }
            [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CPlayerInfo")]
            public partial class CPlayerInfo : global::ProtoBuf.IExtensible
            {
                public CPlayerInfo() { }

                private string _hero_name = "";
                [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"hero_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
                [global::System.ComponentModel.DefaultValue("")]
                public string hero_name
                {
                    get { return _hero_name; }
                    set { _hero_name = value; }
                }
                private string _player_name = "";
                [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
                [global::System.ComponentModel.DefaultValue("")]
                public string player_name
                {
                    get { return _player_name; }
                    set { _player_name = value; }
                }
                private bool _is_fake_client = default(bool);
                [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"is_fake_client", DataFormat = global::ProtoBuf.DataFormat.Default)]
                [global::System.ComponentModel.DefaultValue(default(bool))]
                public bool is_fake_client
                {
                    get { return _is_fake_client; }
                    set { _is_fake_client = value; }
                }
                private ulong _steamid = default(ulong);
                [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
                [global::System.ComponentModel.DefaultValue(default(ulong))]
                public ulong steamid
                {
                    get { return _steamid; }
                    set { _steamid = value; }
                }
                private int _game_team = default(int);
                [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"game_team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
                [global::System.ComponentModel.DefaultValue(default(int))]
                public int game_team
                {
                    get { return _game_team; }
                    set { _game_team = value; }
                }
                private global::ProtoBuf.IExtension extensionObject;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
            }

            [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CHeroSelectEvent")]
            public partial class CHeroSelectEvent : global::ProtoBuf.IExtensible
            {
                public CHeroSelectEvent() { }

                private bool _is_pick = default(bool);
                [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"is_pick", DataFormat = global::ProtoBuf.DataFormat.Default)]
                [global::System.ComponentModel.DefaultValue(default(bool))]
                public bool is_pick
                {
                    get { return _is_pick; }
                    set { _is_pick = value; }
                }
                private uint _team = default(uint);
                [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
                [global::System.ComponentModel.DefaultValue(default(uint))]
                public uint team
                {
                    get { return _team; }
                    set { _team = value; }
                }
                private uint _hero_id = default(uint);
                [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"hero_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
                [global::System.ComponentModel.DefaultValue(default(uint))]
                public uint hero_id
                {
                    get { return _hero_id; }
                    set { _hero_id = value; }
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

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoFileInfo")]
    public partial class CDemoFileInfo : global::ProtoBuf.IExtensible
    {
        public CDemoFileInfo() { }

        private float _playback_time = default(float);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"playback_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        [global::System.ComponentModel.DefaultValue(default(float))]
        public float playback_time
        {
            get { return _playback_time; }
            set { _playback_time = value; }
        }
        private int _playback_ticks = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"playback_ticks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int playback_ticks
        {
            get { return _playback_ticks; }
            set { _playback_ticks = value; }
        }
        private int _playback_frames = default(int);
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"playback_frames", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int playback_frames
        {
            get { return _playback_frames; }
            set { _playback_frames = value; }
        }
        private CGameInfo _game_info = null;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"game_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CGameInfo game_info
        {
            get { return _game_info; }
            set { _game_info = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoPacket")]
    public partial class CDemoPacket : global::ProtoBuf.IExtensible
    {
        public CDemoPacket() { }

        private int _sequence_in = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"sequence_in", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int sequence_in
        {
            get { return _sequence_in; }
            set { _sequence_in = value; }
        }
        private int _sequence_out_ack = default(int);
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"sequence_out_ack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int sequence_out_ack
        {
            get { return _sequence_out_ack; }
            set { _sequence_out_ack = value; }
        }
        private byte[] _data = null;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get { return _data; }
            set { _data = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoFullPacket")]
    public partial class CDemoFullPacket : global::ProtoBuf.IExtensible
    {
        public CDemoFullPacket() { }

        private CDemoStringTables _string_table = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"string_table", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDemoStringTables string_table
        {
            get { return _string_table; }
            set { _string_table = value; }
        }
        private CDemoPacket _packet = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"packet", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CDemoPacket packet
        {
            get { return _packet; }
            set { _packet = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoSyncTick")]
    public partial class CDemoSyncTick : global::ProtoBuf.IExtensible
    {
        public CDemoSyncTick() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoConsoleCmd")]
    public partial class CDemoConsoleCmd : global::ProtoBuf.IExtensible
    {
        public CDemoConsoleCmd() { }

        private string _cmdstring = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"cmdstring", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string cmdstring
        {
            get { return _cmdstring; }
            set { _cmdstring = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoSendTables")]
    public partial class CDemoSendTables : global::ProtoBuf.IExtensible
    {
        public CDemoSendTables() { }

        private byte[] _data = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get { return _data; }
            set { _data = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoClassInfo")]
    public partial class CDemoClassInfo : global::ProtoBuf.IExtensible
    {
        public CDemoClassInfo() { }

        private readonly global::System.Collections.Generic.List<CDemoClassInfo.class_t> _classes = new global::System.Collections.Generic.List<CDemoClassInfo.class_t>();
        [global::ProtoBuf.ProtoMember(1, Name = @"classes", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CDemoClassInfo.class_t> classes
        {
            get { return _classes; }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"class_t")]
        public partial class class_t : global::ProtoBuf.IExtensible
        {
            public class_t() { }

            private int _class_id = default(int);
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"class_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int class_id
            {
                get { return _class_id; }
                set { _class_id = value; }
            }
            private string _network_name = "";
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"network_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string network_name
            {
                get { return _network_name; }
                set { _network_name = value; }
            }
            private string _table_name = "";
            [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"table_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string table_name
            {
                get { return _table_name; }
                set { _table_name = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoCustomData")]
    public partial class CDemoCustomData : global::ProtoBuf.IExtensible
    {
        public CDemoCustomData() { }

        private int _callback_index = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"callback_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int callback_index
        {
            get { return _callback_index; }
            set { _callback_index = value; }
        }
        private byte[] _data = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get { return _data; }
            set { _data = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoCustomDataCallbacks")]
    public partial class CDemoCustomDataCallbacks : global::ProtoBuf.IExtensible
    {
        public CDemoCustomDataCallbacks() { }

        private readonly global::System.Collections.Generic.List<string> _save_id = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(1, Name = @"save_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> save_id
        {
            get { return _save_id; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoStringTables")]
    public partial class CDemoStringTables : global::ProtoBuf.IExtensible
    {
        public CDemoStringTables() { }

        private readonly global::System.Collections.Generic.List<CDemoStringTables.table_t> _tables = new global::System.Collections.Generic.List<CDemoStringTables.table_t>();
        [global::ProtoBuf.ProtoMember(1, Name = @"tables", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CDemoStringTables.table_t> tables
        {
            get { return _tables; }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"items_t")]
        public partial class items_t : global::ProtoBuf.IExtensible
        {
            public items_t() { }

            private string _str = "";
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"str", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string str
            {
                get { return _str; }
                set { _str = value; }
            }
            private byte[] _data = null;
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
            public byte[] data
            {
                get { return _data; }
                set { _data = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"table_t")]
        public partial class table_t : global::ProtoBuf.IExtensible
        {
            public table_t() { }

            private string _table_name = "";
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"table_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string table_name
            {
                get { return _table_name; }
                set { _table_name = value; }
            }
            private readonly global::System.Collections.Generic.List<CDemoStringTables.items_t> _items = new global::System.Collections.Generic.List<CDemoStringTables.items_t>();
            [global::ProtoBuf.ProtoMember(2, Name = @"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
            public global::System.Collections.Generic.List<CDemoStringTables.items_t> items
            {
                get { return _items; }
            }

            private readonly global::System.Collections.Generic.List<CDemoStringTables.items_t> _items_clientside = new global::System.Collections.Generic.List<CDemoStringTables.items_t>();
            [global::ProtoBuf.ProtoMember(3, Name = @"items_clientside", DataFormat = global::ProtoBuf.DataFormat.Default)]
            public global::System.Collections.Generic.List<CDemoStringTables.items_t> items_clientside
            {
                get { return _items_clientside; }
            }

            private int _table_flags = default(int);
            [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"table_flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(default(int))]
            public int table_flags
            {
                get { return _table_flags; }
                set { _table_flags = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoStop")]
    public partial class CDemoStop : global::ProtoBuf.IExtensible
    {
        public CDemoStop() { }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CDemoUserCmd")]
    public partial class CDemoUserCmd : global::ProtoBuf.IExtensible
    {
        public CDemoUserCmd() { }

        private int _cmd_number = default(int);
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"cmd_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
        [global::System.ComponentModel.DefaultValue(default(int))]
        public int cmd_number
        {
            get { return _cmd_number; }
            set { _cmd_number = value; }
        }
        private byte[] _data = null;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public byte[] data
        {
            get { return _data; }
            set { _data = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::ProtoBuf.ProtoContract(Name = @"EDemoCommands")]
    public enum EDemoCommands
    {

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_Error", Value = -1)]
        DEM_Error = -1,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_Stop", Value = 0)]
        DEM_Stop = 0,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_FileHeader", Value = 1)]
        DEM_FileHeader = 1,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_FileInfo", Value = 2)]
        DEM_FileInfo = 2,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_SyncTick", Value = 3)]
        DEM_SyncTick = 3,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_SendTables", Value = 4)]
        DEM_SendTables = 4,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_ClassInfo", Value = 5)]
        DEM_ClassInfo = 5,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_StringTables", Value = 6)]
        DEM_StringTables = 6,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_Packet", Value = 7)]
        DEM_Packet = 7,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_SignonPacket", Value = 8)]
        DEM_SignonPacket = 8,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_ConsoleCmd", Value = 9)]
        DEM_ConsoleCmd = 9,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_CustomData", Value = 10)]
        DEM_CustomData = 10,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_CustomDataCallbacks", Value = 11)]
        DEM_CustomDataCallbacks = 11,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_UserCmd", Value = 12)]
        DEM_UserCmd = 12,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_FullPacket", Value = 13)]
        DEM_FullPacket = 13,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_Max", Value = 14)]
        DEM_Max = 14,

        [global::ProtoBuf.ProtoEnum(Name = @"DEM_IsCompressed", Value = 112)]
        DEM_IsCompressed = 112
    }
}
