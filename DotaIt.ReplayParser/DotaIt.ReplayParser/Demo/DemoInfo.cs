namespace DotaIt.ReplayParser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using DotaIt.ReplayParser.Demo;
    using DotaIt.ReplayParser.Demo.CombatLog;
    using DotaIt.ReplayParser.DemoProto;
    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.DemoProto.UserMessage;

    /// <summary>
    ///     The foreplay.
    /// </summary>
    public class DemoInfo
    {
        public event CombatLogEventHandler OnCombatLog;

        #region Fields

        /// <summary>
        /// The _class info.
        /// </summary>
        private Dictionary<int, CDemoClassInfo.class_t> _classInfo = new Dictionary<int, CDemoClassInfo.class_t>();

        /// <summary>
        /// The _class info message list.
        /// </summary>
        private List<DemoMessageClassInfo> _classInfoMessageList = new List<DemoMessageClassInfo>();

        /// <summary>
        /// The _demo message list.
        /// </summary>
        private List<DemoMessageBase> _demoMessageList = new List<DemoMessageBase>();

        /// <summary>
        /// The _file header.
        /// </summary>
        private DemoMessageFileHeader _fileHeader;

        /// <summary>
        /// The _game event descriptors.
        /// </summary>
        private GameEventDescriptorDic _gameEventDescriptors = new GameEventDescriptorDic();

        /// <summary>
        /// The _game events.
        /// </summary>
        private List<GameEvent> _gameEvents = new List<GameEvent>();

        /// <summary>
        /// The _modifiers.
        /// </summary>
        private DotaMofifierDic _modifiers = new DotaMofifierDic();

        /// <summary>
        /// The _packets.
        /// </summary>
        private List<PacketMessageBase> _packets = new List<PacketMessageBase>();

        /// <summary>
        /// The _string tables.
        /// </summary>
        private StringTableDic _stringTables = new StringTableDic();

        private DemoCombatLogHelper _combatLogHelper;

        private int _processedGameEventCount;

        private List<UserMessageBase> _userMessages = new List<UserMessageBase>();

        private DTClassDic _dtClasses = new DTClassDic();

        private Entity[] _entities = new Entity[1 << Handle.INDEX_BITS];

        #endregion

        #region Public Properties

        public Entity[] Entities
        {
            get
            {
                return this._entities;
            }
        }

        public DTClassDic DtClasses
        {
            get
            {
                return this._dtClasses;
            }
        }

        public List<UserMessageBase> UserMessages
        {
            get
            {
                return this._userMessages;
            }
        }

        /// <summary>
        /// Gets the class info.
        /// </summary>
        public Dictionary<int, CDemoClassInfo.class_t> ClassInfo
        {
            get
            {
                return this._classInfo;
            }
        }

        /// <summary>
        /// Gets the demo message list.
        /// </summary>
        public List<DemoMessageBase> DemoMessageList
        {
            get
            {
                return this._demoMessageList;
            }
        }

        /// <summary>
        /// Gets the file header.
        /// </summary>
        public DemoMessageFileHeader FileHeader
        {
            get
            {
                return this._fileHeader;
            }
            set
            {
                this._fileHeader = value;
            }
        }

        /// <summary>
        /// Gets the game event descriptors.
        /// </summary>
        public GameEventDescriptorDic GameEventDescriptors
        {
            get
            {
                return this._gameEventDescriptors;
            }
        }

        /// <summary>
        /// Gets the game events.
        /// </summary>
        public List<GameEvent> GameEvents
        {
            get
            {
                return this._gameEvents;
            }
        }

        /// <summary>
        /// Gets the modifiers.
        /// </summary>
        public DotaMofifierDic Modifiers
        {
            get
            {
                return this._modifiers;
            }
        }

        /// <summary>
        /// Gets the packets.
        /// </summary>
        public List<PacketMessageBase> Packets
        {
            get
            {
                return this._packets;
            }
        }

        /// <summary>
        /// Gets the string tables.
        /// </summary>
        public StringTableDic StringTables
        {
            get
            {
                return this._stringTables;
            }
        }


        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The initialize.
        /// </summary>
        public void Initialize()
        {

        }

        /// <summary>
        /// The update string table.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="list">
        /// The list.
        /// </param>
        public void UpdateStringTable(int id, List<StringTableItem> list)
        {
            SvcCreateStringTable table = this._stringTables[id];
            UpdateStringTable(table, list);
        }

        /// <summary>
        /// The update string table.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="list">
        /// The list.
        /// </param>
        public void UpdateStringTable(string name, List<StringTableItem> list)
        {
            SvcCreateStringTable table = this._stringTables[name];
            UpdateStringTable(table, list);
        }

        public void PublishCurrentData()
        {
            for (; _processedGameEventCount < this._gameEvents.Count; _processedGameEventCount++)
            {
                GameEvent gameEvent = _gameEvents[_processedGameEventCount];
                string eventName = this._gameEventDescriptors[gameEvent.EventId].name;
                switch (eventName)
                {
                    case DemoCombatLogBase.CombatLog_Descriptor_Name:
                        if (OnCombatLog != null)
                        {
                            EnsureCombatLogHelperExist();
                            DemoCombatLogBase combatLog = _combatLogHelper.CreateCombatLog(gameEvent);
                            OnCombatLog(this, new CombatLogEventArgs(combatLog));
                        }
                        break;
                }
            }
        }

        private void EnsureCombatLogHelperExist()
        {
            if (_combatLogHelper == null)
            {
                _combatLogHelper = new DemoCombatLogHelper(
                    _stringTables[DemoCombatLogBase.CombatLog_StringTable_Name],
                    _gameEventDescriptors[DemoCombatLogBase.CombatLog_Descriptor_Name]);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The process class info.
        /// </summary>
        private void ProcessClassInfo()
        {
            this.DemoMessageList.Where(x => x.Kind == DemoCommandKind.DEM_ClassInfo).ToList().ForEach(
                y =>
                    {
                        y.BuildMessageInstance();
                        this._classInfoMessageList.Add(y as DemoMessageClassInfo);
                    });

            this._classInfoMessageList.ForEach(
                x => x.MessageInstance.classes.ForEach(y => this.ClassInfo.Add(y.class_id, y)));
        }

        /// <summary>
        /// The update string table.
        /// </summary>
        /// <param name="table">
        /// The table.
        /// </param>
        /// <param name="list">
        /// The list.
        /// </param>
        private void UpdateStringTable(SvcCreateStringTable table, List<StringTableItem> list)
        {
            foreach (StringTableItem item in list)
            {
                if (table.Name == "ActiveModifiers")
                {
                    if (item.Value == null)
                    {
                        return;
                    }

                    CDOTAModifierBuffTableEntry mod =
                        Helper.DeserilizedFromBytes<CDOTAModifierBuffTableEntry>(item.Value.ToByteArray());
                    this._modifiers.Add(mod);
                }
                else
                {
                    table.SetValue(item.Index, item.Key, item.Value);
                }
            }
        }

        #endregion
    }

    public delegate void CombatLogEventHandler(object sender, CombatLogEventArgs args);

    public class CombatLogEventArgs : EventArgs
    {
        public DemoCombatLogBase CombatLog { get; set; }

        public CombatLogEventArgs(DemoCombatLogBase log)
        {
            this.CombatLog = log;
        }
    }
}