namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The int decoder.
    /// </summary>
    public class IntDecoder : IPropDecoder<int>
    {
        //TODO
        public int Decode(EntityBitStream stream, IProp prop)
        {
            int v = 0;
            bool isUnsigned = prop.HasFlag(PropFlag.Unsigned);
            int uFlag = (int)PropFlag.Unsigned;
            int selfUnsigned = isUnsigned ? uFlag : 0;
            if (prop.HasFlag(PropFlag.EncodedAgainstTickcount))
            {
                v = stream.ReadVarInt();
                if (isUnsigned)
                {
                    return v;
                }

                return (-(v & uFlag) ^ v >> uFlag);
            }

            v = stream.ReadInt32(prop.num_bits);
            int s = (int)(0x80000000 >> (32 - prop.num_bits)) & (selfUnsigned - uFlag);
            return (v ^ s) - s;
        }

        public object DecodeToObj(EntityBitStream stream, IProp prop)
        {
            return this.Decode(stream, prop);
        }
    }
}