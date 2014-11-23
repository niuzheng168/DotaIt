namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;

    using ProtoBuf;

    /// <summary>
    /// The foreplay.
    /// </summary>
    public class DemoForeplay
    {
        private List<DemoMessageBase> _demoMessageList = new List<DemoMessageBase>();

        public List<DemoMessageBase> DemoMessageList
        {
            get
            {
                return this._demoMessageList;
            }
        }

        private List<DemoMessageSignonPacket> _signonPackets = new List<DemoMessageSignonPacket>();

        public List<DemoMessageSignonPacket> SignonPackets
        {
            get
            {
                return this._signonPackets;
            }
        }

        private List<MessageBase> _unPackedMessageList = new List<MessageBase>();

        public List<MessageBase> UnPackedMessageList
        {
            get
            {
                return _unPackedMessageList;
            }
        }

        public void UnpackSignonPackets()
        {
            foreach (DemoMessageSignonPacket packet in SignonPackets)
            {
                using (MemoryStream ms = new MemoryStream(packet.MessageInstance.Data))
                {
                    int kindValue = ProtoReader.DirectReadVarintInt32(ms);
                    int size = ProtoReader.DirectReadVarintInt32(ms);
                    byte[] buffer = new byte[size];
                    ms.Read(buffer, 0, size);
                    MessageBase m = SignonPacketMessageFactory.CreateMessage(kindValue, buffer);
                    if (m != null)
                    {
                        m.BuildMessageInstance();
                        _unPackedMessageList.Add(m);
                    }
                }
            }
        }
    }

    internal static class SignonPacketMessageFactory
    {
        static Dictionary<int, Type> MessageTypeMap = new Dictionary<int, Type>();
        static Dictionary<int, Func<int, byte[], MessageBase>> MessageCreatorMap = new Dictionary<int, Func<int, byte[], MessageBase>>();

        static SignonPacketMessageFactory()
        {
            MessageTypeMap.Add((int)NetMessageKind.net_SetConVar, typeof(DemoNetMessage<CNETMsg_SetConVar_Proto>));
            MessageTypeMap.Add((int)SVCMessageKind.svc_ServerInfo, typeof(DemoSVCMassage<CSVCMsg_ServerInfo_Proto>));


            MessageCreatorMap.Add((int)NetMessageKind.net_SetConVar, DemoNetMessage<CNETMsg_SetConVar_Proto>.Create);
            MessageCreatorMap.Add((int)SVCMessageKind.svc_ServerInfo, DemoSVCMassage<CSVCMsg_ServerInfo_Proto>.Create);
        }

        internal static MessageBase CreateMessage(int kindValue, byte[] message)
        {
            if (MessageTypeMap.ContainsKey(kindValue))
            {
                var creator = MessageCreatorMap[kindValue];
                var m = creator.Invoke(kindValue, message);
                return m;
            }
            else
            {
                Debug.WriteLine(string.Format("Invalid message kind in signon packets: {0}"), kindValue);
                return null;
            }
        }
    }
}