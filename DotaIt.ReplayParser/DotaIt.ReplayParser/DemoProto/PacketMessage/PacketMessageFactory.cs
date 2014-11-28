namespace DotaIt.ReplayParser.DemoProto.PacketMessage
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The packet message factory.
    /// </summary>
    public static class PacketMessageFactory
    {
        //internal static Type CreateMessage(int kindValue, byte[] message, out MessageBase instance)
        //{
        //    if (MessageCreatorMap.ContainsKey(kindValue))
        //    {
        //        var creator = MessageCreatorMap[kindValue];
        //        Type type = creator.Invoke(kindValue, message, out instance);
        //        return type;
        //    }
        //    else
        //    {
        //        Debug.WriteLine("Invalid message kind in signon packets: {0}", kindValue);
        //        instance = null;
        //        return default(Type);
        //    }
        //}

        public static PacketMessageBase CreatePacketMessage(int kindValue, byte[] messageBody, int tick = -1)
        {
            PacketMessageBase message = null;

            switch (kindValue)
            {
                case (int)NET_Messages_Kind.net_SetConVar:
                    message = new NetSetConVar(kindValue, messageBody, tick);
                    break;
                case (int)NET_Messages_Kind.net_Tick:
                    message = new NetTick(kindValue, messageBody, tick);
                    break;
                case (int)NET_Messages_Kind.net_SignonState:
                    message = new NetSignonState(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_ClassInfo:
                    message = new SvcClassInfo(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_CreateStringTable:
                    message = new SvcCreateStringTable(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_GameEventList:
                    message = new SvcGameEventList(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_Menu:
                    message = new SvcClassInfo(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_PacketEntities:
                    message = new SvcPacketEntities(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_SendTable:
                    message = new SvcSendTable(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_ServerInfo:
                    message = new SvcServerInfo(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_SetView:
                    message = new SvcSetView(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_Sounds:
                    message = new SvcSounds(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_TempEntities:
                    message = new SvcTempEntities(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_UpdateStringTable:
                    message = new SvcUpdateStringTable(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_VoiceInit:
                    message = new SvcVoiceInit(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_VoiceData:
                    message = new SvcVoiceData(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_GameEvent:
                    message = new SvcGameEvent(kindValue, messageBody, tick);
                    break;
                case (int)SVC_Messages_Kind.svc_UserMessage:
                    message = new SvcUserMessage(kindValue, messageBody, tick);
                    break;
                default:
                    break;
            }

            return message;
        }
    }
}