namespace DotaIt.ReplayParser.Demo
{
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    public class Entity
    {
        public int Index { get; set; }

        public int Serial { get; set; }

        public CSVCMsg_SendTable SendTable { get; set; }

        public object[] State { get; set; }

        public PVS Pvs { get; set; }

        public Entity(int index, int serial, CSVCMsg_SendTable table, PVS pvs, object[] state)
        {
            this.Index = index;
            this.Serial = serial;
            this.SendTable = table;
            this.Pvs = pvs;
            this.State = state;
        }
    }

    public enum PVS
    {
        PRESERVE=0,
        ENTER=1,
        LEAVE=2,
        LEAVE_AND_DELETE=3
    }

    public static class Handle
    {
        public static int INDEX_BITS = 11;

        public static int SERIAL_BITS = 10;

        public static int INDEX_MASK = (1 << INDEX_BITS) - 1;

        public static int MAX = (1 << (INDEX_BITS + SERIAL_BITS)) - 1;

        public static int IndexForHandle(int handle)
        {
            return handle & INDEX_MASK;
        }

        public static int SerialForHandle(int handle)
        {
            return handle >> INDEX_BITS;
        }

        public static int ForIndexAndSerial(int index, int serial)
        {
            return serial << INDEX_BITS | index;
        }
    }
}