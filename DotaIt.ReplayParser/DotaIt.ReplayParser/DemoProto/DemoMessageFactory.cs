namespace DotaIt.ReplayParser.DemoProto
{
    /// <summary>
    /// The demo message factory.
    /// </summary>
    internal class DemoMessageFactory
    {
        /// <summary>
        /// Create detailed message according message kind
        /// </summary>
        /// <param name="kind">Message Kind.</param>
        /// <param name="tick">Time tick.</param>
        /// <param name="messageBody">Message body.</param>
        /// <param name="isCompressed">Is message body Compressed.</param>
        /// <returns>Message.</returns>
        internal static DemoMessageBase CreateDemoMessage(DemoCommandKind kind, int tick, byte[] messageBody, bool isCompressed)
        {
            DemoMessageBase message = null;
            switch (kind)
            {
                case DemoCommandKind.DEM_FileInfo:
                    message = new DemoMessageFileInfo(kind, tick, isCompressed, messageBody);
                    break;
                case DemoCommandKind.DEM_FileHeader:
                    message = new DemoMessageFileHeader(kind, tick, isCompressed, messageBody);
                    break;
                default:
                    message = new DemoMessageBase(kind, tick, isCompressed, messageBody);
                    break;
            }

            return message;
        }
    }
}