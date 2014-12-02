namespace DotaIt.ReplayParser.DemoProto.ProtoDef
{
    using System;
    using System.Collections.Generic;

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

        public bool HasFlag(PropFlag flag)
        {
            if ((this.flags & (int)flag) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SendTableExclusion GetExcludeIdentifier()
        {
            return new SendTableExclusion(this.dt_name, this.var_name);
        }
    }

    public partial class CSVCMsg_SendTable
    {
        public int ClassId { get; set; }

        public List<ReceiveProp> ReceiveProps { get; set; }

        public Dictionary<string, int> PropsByName { get; set; }

        private CSVCMsg_SendTable SuperClass;

        public HashSet<SendTableExclusion> GetAllExclusions()
        {
            HashSet<SendTableExclusion> result = new HashSet<SendTableExclusion>();
            foreach (sendprop_t sp in props)
            {
                if(sp.HasFlag(PropFlag.Exclude))
                {
                    result.Add(sp.GetExcludeIdentifier());
                }
            }

            return result;
        }

        public List<sendprop_t> GetAllRelations()
        {
            List<sendprop_t> result = new List<sendprop_t>(props);
            for (int i = 0; i < result.Count; i++)
            {
                var sp = result[i];
                if (sp.HasFlag(PropFlag.Exclude) || sp.type != (int)PropType.DataTable)
                {
                    result.Remove(sp);
                }
            }

            return result;
        }

        public List<sendprop_t> GetAllNonExclusions()
        {
            List<sendprop_t> result = new List<sendprop_t>(props);
            for (int i = 0; i < result.Count; i++)
            {
                var sp = result[i];
                if (sp.HasFlag(PropFlag.Exclude))
                {
                    result.Remove(sp);
                }
            }

            return result;
        }

        public void SetReceiveProps(List<ReceiveProp> receiveProps)
        {
            this.ReceiveProps = receiveProps;
            this.PropsByName = new Dictionary<string, int>();
            for (int i = 0; i < receiveProps.Count; i++)
            {
                var prop = receiveProps[i];
                this.PropsByName.Add(prop.Name, i);
            }
        }
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