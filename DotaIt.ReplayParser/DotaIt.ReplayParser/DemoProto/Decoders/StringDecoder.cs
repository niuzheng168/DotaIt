namespace DotaIt.ReplayParser.DemoProto.Decoders
{
    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The string decoder.
    /// </summary>
    public class StringDecoder : IPropDecoder<string>
    {
        public string Decode(EntityBitStream stream, IProp prop)
        {
            int len = stream.ReadInt32(9);
            return stream.ReadString(len);
        }

        public object DecodeToObj(EntityBitStream stream, IProp prop)
        {
            return this.Decode(stream, prop);
        }
    }
}