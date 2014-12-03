namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using System;
    using System.ComponentModel;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The float decoder.
    /// </summary>
    public class FloatDecoder : IPropDecoder<float>
    {
        private static int COORD_INTEGER_BITS = 14;

        private static int COORD_FRACTIONAL_BITS = 5;

        private static int COORD_DENOMINATOR = (1 << COORD_FRACTIONAL_BITS);

        private static float COORD_RESOLUTION = (1.0f / COORD_DENOMINATOR);

        private static int COORD_INTEGER_BITS_MP = 11;

        private static int COORD_FRACTIONAL_BITS_MP_LOWPRECISION = 3;

        private static int COORD_DENOMINATOR_LOWPRECISION = (1 << COORD_FRACTIONAL_BITS_MP_LOWPRECISION);

        private static float COORD_RESOLUTION_LOWPRECISION = (1.0f / COORD_DENOMINATOR_LOWPRECISION);

        private static int NORMAL_FRACTIONAL_BITS = 11;

        private static int NORMAL_DENOMINATOR = ((1 << NORMAL_FRACTIONAL_BITS) - 1);

        private static float NORMAL_RESOLUTION = (1.0f / NORMAL_DENOMINATOR);

        public float Decode(EntityBitStream stream, IProp prop)
        {
            if (prop.HasFlag(PropFlag.Coord))
            {
                return DecodeCoord(stream);
            }
            else if (prop.HasFlag(PropFlag.CoordMP))
            {
                return DecodeFloatCoordMp(stream, false, false);
            }
            else if (prop.HasFlag(PropFlag.CoordMPLowPrecision))
            {
                return DecodeFloatCoordMp(stream, false, true);
            }
            else if (prop.HasFlag(PropFlag.CoordMPIntegral))
            {
                return DecodeFloatCoordMp(stream, true, false);
            }
            else if (prop.HasFlag(PropFlag.NoScale))
            {
                return DecodeNoScale(stream);
            }
            else if (prop.HasFlag(PropFlag.Normal))
            {
                return DecodeNormal(stream);
            }
            else if (prop.HasFlag(PropFlag.CellCoord))
            {
                return DecodeCellCoord(stream, prop.num_bits);
            }
            else if (prop.HasFlag(PropFlag.CellCoordIntegral))
            {
                return decodeCellCoordIntegral(stream, prop.num_bits);
            }
            else
            {
                return decodeDefault(stream, prop.num_bits, prop.high_value, prop.low_value);
            }
        }

        public float DecodeCoord(EntityBitStream stream)
        {
            bool hasInt = stream.ReadBit();
            bool hasFrac = stream.ReadBit();

            if (!(hasInt || hasFrac))
            {
                return 0.0f;
            }

            bool sign = stream.ReadBit();
            int i = 0;
            int f = 0;

            if (hasInt)
            {
                i = stream.ReadInt32(COORD_INTEGER_BITS) + 1;
            }

            if (hasFrac)
            {
                f = stream.ReadInt32(COORD_FRACTIONAL_BITS);
            }

            float v = i + ((float)f * COORD_RESOLUTION);

            return sign ? -v : v;
        }

        public float DecodeFloatCoordMp(EntityBitStream stream, bool integral, bool lowPrecision)
        {
            int i = 0;
            int f = 0;
            bool sign = false;
            float value = 0.0f;

            bool inBounds = stream.ReadBit();
            if (integral)
            {
                i = stream.ReadInt32(1);
                if (i != 0)
                {
                    sign = stream.ReadBit();
                    value = stream.ReadInt32(inBounds ? COORD_INTEGER_BITS_MP : COORD_INTEGER_BITS) + 1;
                }
            }
            else
            {
                i = stream.ReadInt32(1);
                sign = stream.ReadBit();
                if (i != 0)
                {
                    i = stream.ReadInt32(inBounds ? COORD_INTEGER_BITS_MP : COORD_INTEGER_BITS) + 1;
                }

                f = stream.ReadInt32(lowPrecision ? COORD_FRACTIONAL_BITS_MP_LOWPRECISION : COORD_FRACTIONAL_BITS);
                value = i + ((float)f * (lowPrecision ? COORD_RESOLUTION_LOWPRECISION : COORD_RESOLUTION));
            }

            return sign ? -value : value;
        }

        public float DecodeNoScale(EntityBitStream stream)
        {
            byte[] buffer = stream.ReadBytes(32);
            return BitConverter.ToSingle(buffer, 0);
        }

        public float DecodeNormal(EntityBitStream stream)
        {
            bool isNegative = stream.ReadBit();
            int l = stream.ReadInt32(NORMAL_FRACTIONAL_BITS);
            float v = (float)l * NORMAL_RESOLUTION;
            return isNegative ? -v : v;
        }

        public float DecodeCellCoord(EntityBitStream stream, int numBits)
        {
            int v = stream.ReadInt32(numBits);
            return v + COORD_RESOLUTION * stream.ReadInt32(COORD_FRACTIONAL_BITS);
        }

        public float decodeCellCoordIntegral(EntityBitStream stream, int numBits)
        {
            int v = stream.ReadInt32(numBits);
            return (float)v;
        }

        public float decodeDefault(EntityBitStream stream, int numBits, float high, float low)
        {
            int t = stream.ReadInt32(numBits);
            float f = (float)t / ((1 << numBits) - 1);
            return f * (high - low) + low;
        }

        public object DecodeToObj(EntityBitStream stream, IProp prop)
        {
            return this.Decode(stream, prop);
        }
    }
}