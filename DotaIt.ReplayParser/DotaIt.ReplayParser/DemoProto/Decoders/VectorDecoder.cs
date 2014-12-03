namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using System;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The vector decoder.
    /// </summary>
    public class VectorDecoder : IPropDecoder<Vector3F>
    {
        public Vector3F Decode(EntityBitStream stream, IProp prop)
        {
            FloatDecoder fd = new FloatDecoder();
            float x = fd.Decode(stream, prop);
            float y = fd.Decode(stream, prop);
            float z = 0.0f;
            if (prop.HasFlag(PropFlag.Normal))
            {
                float f = x * x + y * y;
                z = 1.0f > f ? 0.0f : (float)Math.Sqrt(1.0f - f);
                z = stream.ReadBit() ? -z : z;
            }
            else
            {
                z = fd.Decode(stream, prop);
            }

            return new Vector3F(x, y, z);
        }

        public object DecodeToObj(EntityBitStream stream, IProp prop)
        {
            return this.Decode(stream, prop);
        }
    }

    public class Vector3F : Tuple<float, float, float>
    {
        public Vector3F(float item1, float item2, float item3)
            : base(item1, item2, item3)
        {
        }
    }
}