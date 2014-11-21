namespace DotaIt.ReplayParser.Protobuf
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using ProtoBuf;

    [ProtoContract]
    public class DemoFileInfo
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.FixedSize)]
        public float PlayBackTime { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int PlayBackTicks { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int PlayBackFrames { get; set; }

        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.Default)]
        public GameInfo GameInfo { get; set; }
    }

    [ProtoContract]
    public class GameInfo
    {
        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.Default)]
        public DotaGameInfo DotaGameInfo { get; set; }
    }

    [ProtoContract]
    public class DotaGameInfo
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint MatchId { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int GameMode { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int GameWinner { get; set; }

        [ProtoMember(4, IsRequired = false, DataFormat = DataFormat.Default)]
        public List<PlayerInfo> PlayerList { get; set; }

        [ProtoMember(5, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint LeagueId { get; set; }

        [ProtoMember(6, IsRequired = false, DataFormat = DataFormat.Default)]
        public List<BanPickInfo> BanPickList { get; set; }

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
    public class PlayerInfo
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
    public class BanPickInfo
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.Default)]
        public bool IsPick { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint TeamId { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public uint HeroId { get; set; }
    }
}