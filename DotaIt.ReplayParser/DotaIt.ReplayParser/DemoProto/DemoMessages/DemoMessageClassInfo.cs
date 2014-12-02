namespace DotaIt.ReplayParser.DemoProto
{
    using System.Collections.Generic;
    using System.IO;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    using ProtoBuf;

    /// <summary>
    /// The demo message class info.
    /// </summary>
    public class DemoMessageClassInfo : DemoMessageBase, IAnalysable
    {
        public DemoMessageClassInfo(int kindValue, int tick, byte[] message)
            : base(kindValue, tick, message)
        {
            this._kind = DemoCommandKind.DEM_ClassInfo;
        }

        private CDemoClassInfo _classInfo;

        public new CDemoClassInfo MessageInstance
        {
            get
            {
                return _classInfo;
            }
        }

        public override void BuildMessageInstance()
        {
            base.BuildMessageInstance();
            _classInfo = Helper.DeserilizedFromBytes<CDemoClassInfo>(Message);
        }

        public void AnalysisMessage(DemoInfo demo)
        {
            this.BuildMessageInstance();
            foreach (CDemoClassInfo.class_t item in _classInfo.classes)
            {
                demo.DtClasses.SetClassIdForDtName(item.table_name, item.class_id);
            }
        }
    }
}