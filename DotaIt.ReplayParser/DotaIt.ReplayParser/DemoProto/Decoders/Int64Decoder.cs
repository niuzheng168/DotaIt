namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The int 64 decoder.
    /// </summary>
    public class Int64Decoder : IPropDecoder<long>
    {
        public long Decode(EntityBitStream stream, IProp prop)
        {
            bool isUnsigned = prop.HasFlag(PropFlag.Unsigned);
            if (prop.HasFlag(PropFlag.EncodedAgainstTickcount))
            {
                long v = stream.ReadVarInt();
                if (isUnsigned)
                {
                    return v;
                }

                // TODO
                return -(v & 1L) ^ (v >> 1);
            }

            bool negete = false;
            int remainder = prop.num_bits - 32;
            if (!isUnsigned)
            {
                remainder = -1;
                negete = stream.ReadBit();
            }

            long l = stream.ReadInt32(32);
            long r = stream.ReadInt32(remainder);
            long v2 = (r << 32) | l;

            return negete ? -v2 : v2;
        }

        public object DecodeToObj(EntityBitStream stream, IProp prop)
        {
            return this.Decode(stream, prop);
        }
    }
}