namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The array decoder.
    /// </summary>
    public class ArrayDecoder : IPropDecoder<object[]>
    {
        public object[] Decode(EntityBitStream stream, IProp prop)
        {
            int count = stream.ReadInt32(Helper.GetBitLength(prop.num_elements - 1));
            object[] result = new object[count];
            IPropDecoder decoder = PropDecoderDic.Decoders[(PropType)prop.Template.type];
            int i = 0;
            while (i < count)
            {
                result[i] = decoder.DecodeToObj(stream, prop.Template);
                i++;
            }

            return result;
        }

        public object DecodeToObj(EntityBitStream stream, IProp prop)
        {
            return this.Decode(stream, prop);
        }
    }
}