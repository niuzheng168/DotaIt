namespace DotaIt.ReplayParser.Utility
{
    using System.Collections.Generic;

    using DotaIt.ReplayParser.Demo;

    /// <summary>
    /// The entity bit stream.
    /// </summary>
    public class EntityBitStream : BitStreamReader
    {
        public EntityBitStream(byte[] buffer)
            : base(buffer)
        {
        }

        public EntityBitStream(byte[] buffer, int startIndex)
            : base(buffer, startIndex)
        {
        }

        public int ReadEntityIndex(int baseIndex)
        {
            int offset = this.ReadInt32(6);
            switch (offset & 48)
            {
                case 16:
                    offset = (offset & 15) | (this.ReadInt32(4) << 4);
                    break;
                case 32:
                    offset = (offset & 15) | (this.ReadInt32(8) << 4);
                    break;
                case 48:
                    offset = (offset & 15) | (this.ReadInt32(28) << 4);
                    break;
            }

            return baseIndex + offset + 1;
        }

        public PVS ReadEntityPvs()
        {
            int value = (this.ReadInt32(1) << 1) | this.ReadInt32(1);
            return (PVS)value;
        }

        public List<int> ReadEntityPropList()
        {
            List<int> propList = new List<int>();
            int cursor = -1;
            while (true)
            {
                if (this.ReadBit())
                {
                    cursor += 1;
                }
                else
                {
                    int offset = this.ReadVarInt();
                    if (offset == 0x3fff)
                    {
                        return propList;
                    }
                    else
                    {
                        cursor += offset + 1;
                    }
                }

                propList.Add(cursor);
            }
        }
    }
}