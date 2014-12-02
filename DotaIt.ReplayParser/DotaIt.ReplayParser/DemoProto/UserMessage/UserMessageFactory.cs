namespace DotaIt.ReplayParser.DemoProto.UserMessage
{
    using System;
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The user message factory.
    /// </summary>
    public static class UserMessageFactory
    {
        static UserMessageFactory()
        {
            ClassMapping.Add((int)EBaseUserMessages.UM_SayText2, CUserMsg_SayText2.Create);
            ClassMapping.Add((int)EDotaUserMessages.DOTA_UM_ChatEvent, CDOTAUserMsg_ChatEvent.Create);
        }

        public static UserMessageBase CreateUserMessage(int kind, int tick, byte[] data)
        {
            if (ClassMapping.ContainsKey(kind))
            {
                return ClassMapping[kind].Invoke(tick, data);
            }
            else
            {
                return null;
            }
        }

        public static Dictionary<int, Func<int, byte[], UserMessageBase>> ClassMapping = new Dictionary<int, Func<int, byte[], UserMessageBase>>();
    }
}