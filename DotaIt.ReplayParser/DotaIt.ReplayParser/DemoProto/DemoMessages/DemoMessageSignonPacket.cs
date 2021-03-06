﻿namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;

    using DotaIt.ReplayParser.DemoProto.PacketMessage;
    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The demo message packet.
    /// </summary>
    public class DemoMessageSignonPacket : DemoMessageBase, IPacked
    {
        private DemoMessagePacketProto _packetInfo;

        private List<PacketMessageBase> _unpackedMessageList = new List<PacketMessageBase>();

        public DemoMessageSignonPacket(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_SignonPacket;
        }

        public List<PacketMessageBase> UnpackedMessageList
        {
            get
            {
                return _unpackedMessageList;
            }
        }

        public new DemoMessagePacketProto MessageInstance
        {
            get
            {
                return _packetInfo;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _packetInfo = Helper.DeserilizedFromBytes<DemoMessagePacketProto>(Message);
        }

        public void Unpack()
        {
            this.BuildMessageInstance();
            using (MemoryStream ms = new MemoryStream(this.MessageInstance.Data))
            {
                while (ms.Position < ms.Length)
                {
                    int kindValue = ProtoReader.DirectReadVarintInt32(ms);
                    int size = ProtoReader.DirectReadVarintInt32(ms);
                    byte[] buffer = new byte[size];
                    ms.Read(buffer, 0, size);

                    PacketMessageBase m = PacketMessageFactory.CreatePacketMessage(kindValue, buffer, _tick);
                    if (m != null)
                    {
                        _unpackedMessageList.Add(m);
                    }
                }
            }
        }
    }

    [ProtoContract]
    public class DemoMessagePacketProto
    {
        [ProtoMember(1, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int SequenceIn { get; set; }

        [ProtoMember(2, IsRequired = false, DataFormat = DataFormat.TwosComplement)]
        public int SequenceOutAck { get; set; }

        [ProtoMember(3, IsRequired = false, DataFormat = DataFormat.Default)]
        public byte[] Data { get; set; }
    }
}