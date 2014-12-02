namespace DotaIt.ReplayParser.DemoProto.ProtoDef
{
    using System;

    using DotaIt.ReplayParser.DemoProto.UserMessage;

    public partial class CUserMsg_SayText2 : UserMessageBase
    {
        public static CUserMsg_SayText2 Create(int tick, byte[] data)
        {
            CUserMsg_SayText2 msg = Helper.DeserilizedFromBytes<CUserMsg_SayText2>(data);
            msg.KindValue = (int)EBaseUserMessages.UM_SayText2;
            msg.Tick = tick;
            return msg;
        }
    }

    public partial class CDOTAUserMsg_ChatEvent : UserMessageBase
    {
        public static CDOTAUserMsg_ChatEvent Create(int tick, byte[] data)
        {
            CDOTAUserMsg_ChatEvent msg = Helper.DeserilizedFromBytes<CDOTAUserMsg_ChatEvent>(data);
            msg.KindValue = (int)EDotaUserMessages.DOTA_UM_ChatEvent;
            msg.Tick = tick;
            return msg;
        }
    }

    public partial class sendprop_t
    {
        public CSVCMsg_SendTable Table { get; set; }

        public sendprop_t Template { get; set; }
    }

    public partial class CSVCMsg_SendTable
    {
        public int ClassId { get; set; }
    }

    [Flags]
    public enum PropFlag
    {
        Unsigned = 1 << 0,

        Coord = 1 << 1,

        NoScale = 1 << 2,

        RoundDown = 1 << 3,

        RoundUp = 1 << 4,

        Normal = 1 << 5,

        Exclude = 1 << 6,

        XYZE = 1 << 7,

        InsideArray = 1 << 8,

        ProxyAlways = 1 << 9,

        VectorElem = 1 << 10,

        Collapsible = 1 << 11,

        CoordMP = 1 << 12,

        CoordMPLowPrecision = 1 << 13,

        CoordMPIntegral = 1 << 14,

        CellCoord = 1 << 15,

        CellCoordLowPrecision = 1 << 16,

        CellCoordIntegral = 1 << 17,

        ChangesOften = 1 << 18,

        EncodedAgainstTickcount = 1 << 19
    }

    public enum PropType
    {
        Int = 0,

        Float = 1,

        Vector = 2,

        VectorXY = 3,

        String = 4,

        Array = 5,

        DataTable = 6,

        Int64 = 7
    }

    public enum CombatLogGameState
    {
        Error = 0,
        Waiting_For_Loaders = 1,
        Picking = 2,
        Start = 3,
        PreGame = 4,
        Playing = 5,
        PostGame = 6,
    }
}