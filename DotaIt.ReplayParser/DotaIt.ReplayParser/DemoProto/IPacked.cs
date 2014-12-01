namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto.PacketMessage;

    /// <summary>
    ///     The ackedMessage interface.
    /// </summary>
    internal interface IPacked
    {
        #region Public Properties

        /// <summary>
        /// Gets the unpacked message list.
        /// </summary>
        List<PacketMessageBase> UnpackedMessageList { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The unpack.
        /// </summary>
        void Unpack();

        #endregion
    }
}