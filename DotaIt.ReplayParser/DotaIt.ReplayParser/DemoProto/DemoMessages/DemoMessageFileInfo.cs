namespace DotaIt.ReplayParser.DemoProto
{
    using System.Collections.Generic;
    using System.IO;

    using ProtoBuf;

    /// <summary>
    /// The demo file info message.
    /// </summary>
    public class DemoMessageFileInfo : DemoMessageBase
    {
        #region Fields

        /// <summary>
        /// The _info.
        /// </summary>
        private DemoMessageFileInfoProto _info;

        #endregion

        #region Constructors and Destructors

        public DemoMessageFileInfo(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_FileInfo;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the message instance.
        /// </summary>
        public new DemoMessageFileInfoProto MessageInstance
        {
            get
            {
                return this._info;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The build message instance.
        /// </summary>
        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            using (MemoryStream ms = new MemoryStream(this.Message))
            {
                this._info = Serializer.Deserialize<DemoMessageFileInfoProto>(ms);
            }
        }

        #endregion
    }

    [ProtoContract]
    public class DemoMessageFileInfoProto
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.FixedSize)]
        public float PlayBackTime { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int PlayBackTicks { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int PlayBackFrames { get; set; }

        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.Default)]
        public GameInfoProto GameInfoProto { get; set; }
    }

    [ProtoContract]
    public class GameInfoProto
    {
        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.Default)]
        public DotaGameInfoProto DotaGameInfoProto { get; set; }
    }

    [ProtoContract]
    public class DotaGameInfoProto
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint MatchId { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int GameMode { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int GameWinner { get; set; }

        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.Default)]
        public List<PlayerInfoProto> PlayerList { get; set; }

        [ProtoMember(5, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint LeagueId { get; set; }

        [ProtoMember(6, IsRequired = false, DataFormat = DataFormat.Default)]
        public List<BanPickInfoProto> BanPickList { get; set; }

        [ProtoMember(7, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint RadiantTeamId { get; set; }

        [ProtoMember(8, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint DireTeamId { get; set; }

        [ProtoMember(9, IsRequired = false, DataFormat = DataFormat.Default)]
        public string RadiantTeamName { get; set; }

        [ProtoMember(10, IsRequired = false, DataFormat = DataFormat.Default)]
        public string DireTeamName { get; set; }

        [ProtoMember(11, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint EndTime { get; set; }
    }

    [ProtoContract]
    public class PlayerInfoProto
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.Default)]
        public string HeroName { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.Default)]
        public string PlayerName { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.Default)]
        public bool IsFakeClient { get; set; }

        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public ulong SteamId { get; set; }

        [ProtoMember(5, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int TeamInGame { get; set; }
    }

    [ProtoContract]
    public class BanPickInfoProto
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.Default)]
        public bool IsPick { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint TeamId { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint HeroId { get; set; }
    }
}