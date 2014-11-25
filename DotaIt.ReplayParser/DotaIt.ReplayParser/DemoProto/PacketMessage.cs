﻿namespace DotaIt.ReplayParser.DemoProto
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    internal class PacketMessage
    {
        static Dictionary<int, Type> MessageTypeMap = new Dictionary<int, Type>();
        static Dictionary<int, Func<int, byte[], MessageBase>> MessageCreatorMap = new Dictionary<int, Func<int, byte[], MessageBase>>();

        static PacketMessage()
        {
            // Use reflactor sees slow than function invoke
            //MessageTypeMap.Add((int)NetMessageKind.net_SetConVar, typeof(DemoNetMessage<CNETMsg_SetConVar_Proto>));
            //MessageTypeMap.Add((int)SVCMessageKind.svc_ServerInfo, typeof(DemoSVCMassage<CSVCMsg_ServerInfo_Proto>));

            MessageCreatorMap.Add((int)NET_Messages_Kind.net_SetConVar, DemoNetMessage<CNETMsg_SetConVar>.Create);
            MessageCreatorMap.Add((int)NET_Messages_Kind.net_Tick, DemoNetMessage<CNETMsg_Tick>.Create);
            MessageCreatorMap.Add((int)NET_Messages_Kind.net_SignonState, DemoNetMessage<CNETMsg_SignonState>.Create);

            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_ClassInfo, DemoSVCMassage<CSVCMsg_ClassInfo>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_CreateStringTable, DemoSVCMassage<CSVCMsg_CreateStringTable>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_GameEventList, DemoSVCMassage<CSVCMsg_GameEventList>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_Menu, DemoSVCMassage<CSVCMsg_Menu>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_PacketEntities, DemoSVCMassage<CSVCMsg_PacketEntities>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_SendTable, DemoSVCMassage<CSVCMsg_SendTable>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_ServerInfo, DemoSVCMassage<CSVCMsg_ServerInfo>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_SetView, DemoSVCMassage<CSVCMsg_SetView>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_Sounds, DemoSVCMassage<CSVCMsg_Sounds>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_TempEntities, DemoSVCMassage<CSVCMsg_TempEntities>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_UpdateStringTable, DemoSVCMassage<CSVCMsg_UpdateStringTable>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_VoiceInit, DemoSVCMassage<CSVCMsg_VoiceInit>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_VoiceData, DemoSVCMassage<CSVCMsg_VoiceData>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_GameEvent, DemoSVCMassage<CSVCMsg_GameEvent>.Create);
            MessageCreatorMap.Add((int)SVC_Messages_Kind.svc_UserMessage, DemoSVCMassage<CSVCMsg_UserMessage>.Create);
        }

        internal static MessageBase CreateMessage(int kindValue, byte[] message)
        {
            if (MessageCreatorMap.ContainsKey(kindValue))
            {
                var creator = MessageCreatorMap[kindValue];
                var m = creator.Invoke(kindValue, message);
                return m;
            }
            else
            {
                Debug.WriteLine("Invalid message kind in signon packets: {0}", kindValue);
                return null;
            }
        }
    }
}