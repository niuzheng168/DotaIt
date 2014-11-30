namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    using DotaIt.ReplayParser.Class;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    ///     The net set con var.
    /// </summary>
    public class SvcCreateStringTable : PacketMessageBase
    {
        #region Fields

        /// <summary>
        ///     The _string table.
        /// </summary>
        private CSVCMsg_CreateStringTable _stringTable;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SvcCreateStringTable"/> class.
        /// </summary>
        /// <param name="kindValue">
        /// The kind value.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="tick">
        /// The tick.
        /// </param>
        public SvcCreateStringTable(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the message instance.
        /// </summary>
        public new CSVCMsg_CreateStringTable MessageInstance
        {
            get
            {
                return this._stringTable;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The build message instance.
        /// </summary>
        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._stringTable = Helper.DeserilizedFromBytes<CSVCMsg_CreateStringTable>(this.Message);
        }

        #endregion
    }

    public class StringTableDic
    {
        private List<StringTable> _byId = new List<StringTable>();

        private Dictionary<string, StringTable> _byName = new Dictionary<string, StringTable>();

        public List<StringTable> ById
        {
            get
            {
                return this._byId;
            }
        }

        public Dictionary<string, StringTable> ByName
        {
            get
            {
                return this._byName;
            }
        }

        public StringTable this[int id]
        {
            get
            {
                return _byId[id];
            }
        }

        public StringTable this[string name]
        {
            get
            {
                return _byName[name];
            }
        }

        public void Add(StringTable table)
        {
            this._byId.Add(table);
            this._byName.Add(table.Name, table);
        }
    }

    /// <summary>
    ///     The string table.
    /// </summary>
    public class StringTable
    {
        private const int MAX_NAME_LENGTH = 0x400;

        private const int KEY_HISTORY_SIZE = 32;

        #region Fields

        /// <summary>
        ///     The _flags.
        /// </summary>
        private int _flags;

        /// <summary>
        ///     The _max entries.
        /// </summary>
        private int _maxEntries;

        /// <summary>
        ///     The _name.
        /// </summary>
        private string _name;

        /// <summary>
        ///     The _names.
        /// </summary>
        private string[] _names;

        /// <summary>
        ///     The _user data fixed size.
        /// </summary>
        private bool _userDataFixedSize;

        /// <summary>
        ///     The _user data size.
        /// </summary>
        private int _userDataSize;

        /// <summary>
        ///     The _user data size bits.
        /// </summary>
        private int _userDataSizeBits;

        /// <summary>
        ///     The _values.
        /// </summary>
        private string[] _values;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTable"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="maxEntries">
        /// The max entries.
        /// </param>
        /// <param name="userDataFixedSize">
        /// The user data fixed size.
        /// </param>
        /// <param name="userDataSize">
        /// The user data size.
        /// </param>
        /// <param name="userDataSizeBits">
        /// The user data size bits.
        /// </param>
        /// <param name="flags">
        /// The flags.
        /// </param>
        public StringTable(
            string name, 
            int maxEntries, 
            bool userDataFixedSize, 
            int userDataSize, 
            int userDataSizeBits, 
            int flags)
        {
            this._name = name;
            this._maxEntries = maxEntries;
            this._userDataFixedSize = userDataFixedSize;
            this._userDataSize = userDataSize;
            this._userDataSizeBits = userDataSizeBits;
            this._flags = flags;

            this._names = new string[maxEntries];
            this._values = new string[maxEntries];
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the flags.
        /// </summary>
        public int Flags
        {
            get
            {
                return this._flags;
            }
        }

        /// <summary>
        ///     Gets the max entries.
        /// </summary>
        public int MaxEntries
        {
            get
            {
                return this._maxEntries;
            }
        }

        /// <summary>
        ///     Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        /// <summary>
        ///     Gets the names.
        /// </summary>
        public string[] Names
        {
            get
            {
                return this._names;
            }
        }

        /// <summary>
        ///     Gets a value indicating whether user data fixed size.
        /// </summary>
        public bool UserDataFixedSize
        {
            get
            {
                return this._userDataFixedSize;
            }
        }

        /// <summary>
        ///     Gets the user data size.
        /// </summary>
        public int UserDataSize
        {
            get
            {
                return this._userDataSize;
            }
        }

        /// <summary>
        ///     Gets the user data size bits.
        /// </summary>
        public int UserDataSizeBits
        {
            get
            {
                return this._userDataSizeBits;
            }
        }

        /// <summary>
        ///     Gets the values.
        /// </summary>
        public string[] Values
        {
            get
            {
                return this._values;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The decode from data.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="num">
        /// The num.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<StringTableItem> DecodeFromData(StringTable table, byte[] data, int num)
        {
            List<StringTableItem> result = new List<StringTableItem>();

            BitStreamReader stream = new BitStreamReader(data);

            int bitPerIndex = Helper.GetBitLength(table.MaxEntries - 1);
            List<string> keyHistory = new List<string>();

            bool mysteryFlag = stream.ReadBit();
            int index = -1;
            StringBuilder nameBuf = new StringBuilder();
            while (result.Count < num)
            {
                if (stream.ReadBit())
                {
                    index++;
                }
                else
                {
                    index = stream.ReadInt32(bitPerIndex);
                }

                nameBuf.Clear();
                // read key
                if (stream.ReadBit())
                {
                    if (mysteryFlag && stream.ReadBit())
                    {
                        throw new InvalidDataException();
                    }

                    if (stream.ReadBit())
                    {
                        int basis = stream.ReadInt32(5);
                        int length = stream.ReadInt32(5);
                        nameBuf.Append(keyHistory.ElementAt(basis).Substring(0, length));
                        nameBuf.Append(stream.ReadString(MAX_NAME_LENGTH - length));
                    }
                    else
                    {
                        nameBuf.Append(stream.ReadString(MAX_NAME_LENGTH));
                    }

                    if (keyHistory.Count == KEY_HISTORY_SIZE)
                    {
                        keyHistory.RemoveAt(0);
                    }
                    keyHistory.Add(nameBuf.ToString());
                }

                // read value
                byte[] value = null;
                if (stream.ReadBit())
                {
                    int bitLength = 0;
                    if (table.UserDataFixedSize)
                    {
                        bitLength = table._userDataSizeBits;
                    }
                    else
                    {
                        bitLength = stream.ReadInt32(14) * 8;
                    }

                    value = stream.ReadBytes(bitLength);
                }

                result.Add(new StringTableItem(index, nameBuf.ToString(), value));
            }
            return result;
        }

        /// <summary>
        /// The set value.
        /// </summary>
        /// <param name="idx">
        /// The idx.
        /// </param>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public void SetValue(int idx, string name, string value)
        {
            this._names[idx] = name;
            this._values[idx] = value;
        }

        #endregion
    }

    /// <summary>
    ///     The string table item.
    /// </summary>
    public class StringTableItem
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StringTableItem"/> class.
        /// </summary>
        /// <param name="idx">
        /// The idx.
        /// </param>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public StringTableItem(int idx, string key, byte[] value)
        {
            this.Key = key;
            this.Value = value;
            this.Index = idx;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the index.
        /// </summary>
        public int Index { get; private set; }

        /// <summary>
        ///     Gets the key.
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        ///     Gets the value.
        /// </summary>
        public byte[] Value { get; private set; }

        #endregion
    }
}