namespace DotaIt.ReplayParser.DemoProto.ProtoDef
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    using DotaIt.ReplayParser.Class;
    using DotaIt.ReplayParser.DemoProto.PacketMessage;

    using ProtoBuf;

    public partial class CSVCMsg_SendTable
    {
        public static Expression<Func<CSVCMsg_SendTable, bool>> IsBaseClasee = p => p.net_table_name == "baseclass";
    }

    public partial class table_t
    {
        public Dictionary<int, items_t> ItemsByIndex = new Dictionary<int, items_t>();
        public Dictionary<string, items_t> ItemsByName = new Dictionary<string, items_t>();
    }

    public partial class sendprop_t
    {
        public static Expression<Func<sendprop_t, bool>> IsCollasible = p => ((PropFlag)p.flags).HasFlag(PropFlag.Collapsible);

        public static Expression<Func<sendprop_t, bool>> IsDataTable = p => p.type == (int)PropType.DataTable;

        public static Expression<Func<sendprop_t, bool>> IsExclude = p => ((PropFlag)p.flags).HasFlag(PropFlag.Exclude);

        public static Expression<Func<sendprop_t, bool>> IsInsideArray = p => ((PropFlag)p.flags).HasFlag(PropFlag.InsideArray);

        public static Expression<Func<sendprop_t, bool>> IsNotExclude = p => p.flags == (int)PropFlag.Exclude;

        public string OriginalSendTable { get; set; }
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