namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The prop decoder.
    /// </summary>
    public interface IPropDecoder<out T> : IPropDecoder
    {
        T Decode(EntityBitStream stream, IProp prop);
    }

    public interface IPropDecoder
    {
        object DecodeToObj(EntityBitStream stream, IProp prop);
    }

    public static class PropDecoderDic
    {
        public static Dictionary<PropType, IPropDecoder> Decoders = new Dictionary<PropType, IPropDecoder>();

        static PropDecoderDic()
        {
            Decoders.Add(PropType.Array, new ArrayDecoder());
            Decoders.Add(PropType.Float, new FloatDecoder());
            Decoders.Add(PropType.Int64, new Int64Decoder());
            Decoders.Add(PropType.Int, new IntDecoder());
            Decoders.Add(PropType.String, new StringDecoder());
            Decoders.Add(PropType.Vector, new VectorDecoder());
            Decoders.Add(PropType.VectorXY, new VectorXYDecoder());
        }
    }
}