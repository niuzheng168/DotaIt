namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using System;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The vector xy decoder.
    /// </summary>
    public class VectorXYDecoder : IPropDecoder<Vector2F>
    {
        public Vector2F Decode(EntityBitStream stream, IProp prop)
        {
            FloatDecoder fd = new FloatDecoder();
            float x = fd.Decode(stream, prop);
            float y = fd.Decode(stream, prop);

            return new Vector2F(x, y);
        }

        public object DecodeToObj(EntityBitStream stream, IProp prop)
        {
            return this.DecodeToObj(stream, prop);
        }
    }

    public class Vector2F : Tuple<float, float>
    {
        public Vector2F(float item1, float item2)
            : base(item1, item2)
        {
        }
    }
}