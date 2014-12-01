namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    ///     The net set con var.
    /// </summary>
    public class SvcCreateStringTable : PacketMessageBase, IAnalysable
    {
        #region Fields

        private const int MAX_NAME_LENGTH = 0x400;

        private const int KEY_HISTORY_SIZE = 32;

        private string[] _names;

        private ByteString[] _values;

        public string[] Names
        {
            get
            {
                return this._names;
            }
        }

        public ByteString[] Values
        {
            get
            {
                return this._values;
            }
        }

        public string Name
        {
            get
            {
                return this._stringTable.name;
            }
        }

        public static List<StringTableItem> DecodeFromData(SvcCreateStringTable stringTable, byte[] data, int num)
        {
            List<StringTableItem> result = new List<StringTableItem>();

            BitStreamReader stream = new BitStreamReader(data);

            int bitPerIndex = Helper.GetBitLength(stringTable.MessageInstance.max_entries - 1);
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
                ByteString value = null;
                if (stream.ReadBit())
                {
                    int bitLength = 0;
                    if (stringTable.MessageInstance.user_data_fixed_size)
                    {
                        bitLength = stringTable.MessageInstance.user_data_size_bits;
                    }
                    else
                    {
                        bitLength = stream.ReadInt32(14) * 8;
                    }

                    value =  ByteString.CopyFrom(stream.ReadBytes(bitLength));
                }

                result.Add(new StringTableItem(index, nameBuf.ToString(), value));
            }
            return result;
        }

        public void SetValue(int idx, string name, ByteString value)
        {
            this._names[idx] = name;
            this._values[idx] = value;
        }

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
            this._names = new string[this._stringTable.max_entries];
            this._values = new ByteString[this._stringTable.max_entries];
        }

        #endregion

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();
            demo.StringTables.Add(this);
            var list = DecodeFromData(this, this._stringTable.string_data, this.MessageInstance.num_entries);
            demo.UpdateStringTable(this.Name, list);
        }
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
        public StringTableItem(int idx, string key, ByteString value)
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
        public ByteString Value { get; private set; }

        #endregion
    }
}