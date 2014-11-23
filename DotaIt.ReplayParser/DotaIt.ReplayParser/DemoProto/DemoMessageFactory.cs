namespace DotaIt.ReplayParser.DemoProto
{
    /// <summary>
    /// The demo message factory.
    /// </summary>
    internal class DemoMessageFactory
    {
        internal static DemoMessageBase CreateDemoMessage(int kindValue, int tick, byte[] messageBody)
        {
            DemoMessageBase message = null;
            var RealKind = DemoMessageBase.RealKind(kindValue);
            DemoCommandKind kind = RealKind.Item1;

            switch (kind)
            {
                case DemoCommandKind.DEM_FileInfo:
                    message = new DemoMessageFileInfo(kindValue, tick, messageBody);
                    break;
                case DemoCommandKind.DEM_FileHeader:
                    message = new DemoMessageFileHeader(kindValue, tick, messageBody);
                    break;
                case DemoCommandKind.DEM_SignonPacket:
                    message = new DemoMessageSignonPacket(kindValue, tick, messageBody);
                    break;
                default:
                    message = new DemoMessageBase(kindValue, tick, messageBody);
                    break;
            }

            return message;
        }
    }
}