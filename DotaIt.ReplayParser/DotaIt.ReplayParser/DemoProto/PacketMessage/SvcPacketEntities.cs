namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using System.Collections.Generic;
    using System.Threading;

    using DotaIt.ReplayParser.Demo;
    using DotaIt.ReplayParser.DemoProto.Decoders;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;
    using DotaIt.ReplayParser.Utility;

    /// <summary>
    /// The net set con var.
    /// </summary>
    public class SvcPacketEntities : PacketMessageBase, IAnalysable
    {
        public SvcPacketEntities(int kindValue, byte[] message, int tick)
            : base(kindValue, message, tick)
        {
        }

        private CSVCMsg_PacketEntities _packet;

        public new CSVCMsg_PacketEntities MessageInstance
        {
            get
            {
                return this._packet;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            this._packet = Helper.DeserilizedFromBytes<CSVCMsg_PacketEntities>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();
            PacketEntitiesDecoder decoder = new PacketEntitiesDecoder(
                _packet.entity_data,
                _packet.updated_entries,
                _packet.is_delta,
                demo.DtClasses,
                demo.StringTables["instancebaseline"]);

            decoder.DecodeAndApply(demo.Entities);
        }
    }

    public class PacketEntitiesDecoder
    {
        private int _numEntries;

        private bool _isDelta;

        private DTClassDic _dtClasses;

        private SvcCreateStringTable _baseline;

        private EntityBitStream _stream;

        private int _classBits;

        public PacketEntitiesDecoder(
            byte[] data,
            int numEntries,
            bool isDelta,
            DTClassDic dtClasses,
            SvcCreateStringTable baseline)
        {
            this._numEntries = numEntries;
            this._isDelta = isDelta;
            this._dtClasses = dtClasses;
            this._baseline = baseline;

            this._stream = new EntityBitStream(data);
            this._classBits = Helper.GetBitLength(dtClasses.ById.Count - 1);
        }

        public void DecodeAndApply(Entity[] world)
        {
            int index = -1;
            int count = 0;
            while (count < _numEntries)
            {
                index = DecodeDiff(index, world);
                count++;
            }

            if (_isDelta)
            {
                DecodeDeletionDiffs(world);
            }
        }

        private int DecodeDiff(int index, Entity[] entities)
        {
            index = _stream.ReadEntityIndex(index);
            PVS pvs = _stream.ReadEntityPvs();
            CSVCMsg_SendTable cls = null;
            int serial;
            object[] state = null;
            List<int> propList = null;
            Entity entity = null;

            switch (pvs)
            {
                case PVS.ENTER:
                    int id = _stream.ReadInt32(_classBits);
                    cls = _dtClasses[id];
                    serial = _stream.ReadInt32(10);
                    propList = _stream.ReadEntityPropList();
                    state = DecodeBaseProperities(cls);
                    DecodeProperties(state, cls, propList);
                    Entity item = new Entity(index, serial, cls, pvs, state);
                    entities[index] = item;
                    break;

                case PVS.PRESERVE:
                    entity = entities[index];
                    entity.Pvs = pvs;
                    cls = entity.SendTable;
                    serial = entity.Serial;
                    propList = _stream.ReadEntityPropList();
                    this.DecodeProperties(entity.State, cls, propList);
                    break;

                case PVS.LEAVE:
                    entity = entities[index];
                    entity.Pvs = pvs;
                    break;

                case PVS.LEAVE_AND_DELETE:
                    entities[index] = null;
                    break;
            }

            return index;
        }

        private void DecodeDeletionDiffs(Entity[] entities)
        {
            while (_stream.ReadBit())
            {
                int index = _stream.ReadInt32(11);
                entities[index] = null;
            }
        }

        private object[] DecodeBaseProperities(CSVCMsg_SendTable cls)
        {
            ByteString s = _baseline.GetValueByName(cls.ClassId.ToString());
            return BaseInstanceDecoder.Decode(s.ToByteArray(), cls.ReceiveProps);
        }

        private void DecodeProperties(object[] state, CSVCMsg_SendTable cls, List<int> propList)
        {
            foreach (int i in propList)
            {
                ReceiveProp r = cls.ReceiveProps[i];
                object obj = PropDecoderDic.Decoders[(PropType)r.SendProp.type].DecodeToObj(_stream, r);
                state[i] = obj;
            }
        }
    }

    public class BaseInstanceDecoder
    {
        public static object[] Decode(byte[] data, List<ReceiveProp> receiveProps)
        {
            EntityBitStream stream = new EntityBitStream(data);
            List<int> propList = stream.ReadEntityPropList();

            object[] state = new object[receiveProps.Count];

            foreach (int i in propList)
            {
                ReceiveProp r = receiveProps[i];
                object obj = PropDecoderDic.Decoders[(PropType)r.SendProp.type].DecodeToObj(stream, r);
                state[i] = obj;
            }

            return state;
        }
    }
}