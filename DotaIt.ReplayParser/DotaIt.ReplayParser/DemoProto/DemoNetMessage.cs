namespace DotaIt.ReplayParser.DemoProto
{
    using System;

    using ProtoBuf;

    /// <summary>
    /// The net messages.
    /// </summary>
    public class DemoNetMessage<T> : MessageBase
    {

        private NetMessageKind _kind;

        private T _messageInstance;

        public NetMessageKind Kind
        {
            get
            {
                return _kind;
            }
        }

        public T MessageInstance
        {
            get
            {
                return _messageInstance;
            }
        }

        public DemoNetMessage(int kindValue, byte[] message)
            : base(kindValue, message)
        {
        }

        public override void BuildMessageInstance()
        {
            _messageInstance = Helper.DeserilizedFromBytes<T>(Message);
        }

        public static DemoNetMessage<T> Create(int kind, byte[] message)
        {
            DemoNetMessage<T> netMessage = new DemoNetMessage<T>(kind, message);
            netMessage.BuildMessageInstance();
            return netMessage;
        }
    }

    public enum NetMessageKind
    {
        net_NOP = 0,

        net_Disconnect = 1,

        net_File = 2,

        net_SplitScreenUser = 3,

        net_Tick = 4,

        net_StringCmd = 5,

        net_SetConVar = 6,

        net_SignonState = 7,
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CMsg_CVars")]
    public partial class CMsg_CVars_Proto : global::ProtoBuf.IExtensible
    {
        public CMsg_CVars_Proto() { }

        private readonly global::System.Collections.Generic.List<CMsg_CVars_Proto.CVar_Proto> _cvars = new global::System.Collections.Generic.List<CMsg_CVars_Proto.CVar_Proto>();
        [global::ProtoBuf.ProtoMember(1, Name = @"cvars", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<CMsg_CVars_Proto.CVar_Proto> cvars
        {
            get { return _cvars; }
        }

        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CVar")]
        public partial class CVar_Proto : global::ProtoBuf.IExtensible
        {
            public CVar_Proto() { }

            private string _name = "";
            [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            private string _value = "";
            [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
            public string value
            {
                get { return _value; }
                set { _value = value; }
            }
            private global::ProtoBuf.IExtension extensionObject;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"CNETMsg_SetConVar")]
    public partial class CNETMsg_SetConVar_Proto : global::ProtoBuf.IExtensible
    {
        public CNETMsg_SetConVar_Proto() { }

        private CMsg_CVars_Proto _convars = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"convars", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue(null)]
        public CMsg_CVars_Proto convars
        {
            get { return _convars; }
            set { _convars = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
}