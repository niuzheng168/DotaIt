namespace DotaIt.ReplayParser.DemoProto
{
    using System;

    using Snappy;

    /// <summary>
    ///     The demo message base.
    /// </summary>
    public class DemoMessageBase
    {
        /// <summary>
        /// The kind.
        /// </summary>
        protected DemoCommandKind _kind = DemoCommandKind.DEM_Error;

        /// <summary>
        /// The tick.
        /// </summary>
        protected int _tick = -1;

        /// <summary>
        /// The is compressed.
        /// </summary>
        protected bool _isCompressed = false;

        /// <summary>
        /// The message.
        /// </summary>
        protected byte[] _message = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoMessageBase"/> class.
        /// </summary>
        /// <param name="kind">
        /// The kind.
        /// </param>
        /// <param name="tick">
        /// The tick.
        /// </param>
        /// <param name="isCompressed">
        /// The is compressed.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public DemoMessageBase(DemoCommandKind kind, int tick, bool isCompressed, byte[] message)
        {
            this._kind = kind;
            this._tick = tick;
            this._isCompressed = isCompressed;
            this._message = message;
        }

        /// <summary>
        /// Gets the message instance.
        /// </summary>
        public byte[] MessageInstance
        {
            get
            {
                return this._message;
            }
        }

        /// <summary>
        /// Gets the tick.
        /// </summary>
        public int Tick
        {
            get
            {
                return this._tick;
            }
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        public byte[] Message
        {
            get
            {
                return this._message;
            }
        }

        /// <summary>
        ///     Gets the kind.
        /// </summary>
        public DemoCommandKind Kind
        {
            get
            {
                return this._kind;
            }
        }

        /// <summary>
        ///     Gets a value indicating whether is message compressed.
        /// </summary>
        public bool IsMessageCompressed
        {
            get
            {
                return this._isCompressed;
            }
        }

        /// <summary>
        ///     The real kind.
        /// </summary>
        /// <param name="kindValue">
        ///     The kind value.
        /// </param>
        /// <returns>
        ///     The <see cref="Tuple" />.
        /// </returns>
        public static Tuple<DemoCommandKind, bool> RealKind(int kindValue)
        {
            return
                new Tuple<DemoCommandKind, bool>(
                    (DemoCommandKind)(kindValue & (~(int)DemoCommandKind.DEM_IsCompressed)),
                    kindValue > (int)DemoCommandKind.DEM_IsCompressed);
        }

        /// <summary>
        ///     Decompressed and build message instance.
        /// </summary>
        public virtual void BuildMessageInstance()
        {
            if (this.IsMessageCompressed)
            {
                this._message = SnappyCodec.Uncompress(this.Message);
            }
        }
    }

    /// <summary>
    /// The DemoCommands.
    /// </summary>
    [Flags]
    public enum DemoCommandKind
    {
        DEM_Error = -1,

        DEM_Stop = 0,

        DEM_FileHeader = 1,

        DEM_FileInfo = 2,

        DEM_SyncTick = 3,

        DEM_SendTables = 4,

        DEM_ClassInfo = 5,

        DEM_StringTables = 6,

        DEM_Packet = 7,

        DEM_SignonPacket = 8,

        DEM_ConsoleCmd = 9,

        DEM_CustomData = 10,

        DEM_CustomDataCallbacks = 11,

        DEM_UserCmd = 12,

        DEM_FullPacket = 13,

        DEM_Max = 14,

        DEM_IsCompressed = 112,
    }
}