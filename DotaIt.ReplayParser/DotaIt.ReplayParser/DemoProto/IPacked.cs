namespace DotaIt.ReplayParser.DemoProto
{
    using System.Collections.Generic;

    /// <summary>
    /// The ackedMessage interface.
    /// </summary>
    internal interface IPacked
    {
        void Unpack();
        List<MessageBase> UnpackedMessageList { get; }
    }
}