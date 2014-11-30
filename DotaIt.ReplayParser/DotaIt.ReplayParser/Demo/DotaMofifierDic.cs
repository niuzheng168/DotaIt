namespace DotaIt.ReplayParser.Demo
{
    using System.Collections.Generic;

    using DotaIt.ReplayParser.DemoProto.ProtoDef;

    /// <summary>
    /// The dota mofifier dic.
    /// </summary>
    public class DotaMofifierDic
    {
        private List<CDOTAModifierBuffTableEntry> _modifiers = new List<CDOTAModifierBuffTableEntry>();

        public List<CDOTAModifierBuffTableEntry> Modifiers
        {
            get
            {
                return this._modifiers;
            }
        }

        private Dictionary<int, List<CDOTAModifierBuffTableEntry>> _modifiersForEntity =
            new Dictionary<int, List<CDOTAModifierBuffTableEntry>>();

        public Dictionary<int, List<CDOTAModifierBuffTableEntry>> ModifiersForEntity
        {
            get
            {
                return this._modifiersForEntity;
            }
        }

        public void Add(CDOTAModifierBuffTableEntry mod)
        {
            this._modifiers.Add(mod);
            if (this._modifiersForEntity.ContainsKey(mod.parent))
            {
                this._modifiersForEntity[mod.parent].Add(mod);
            }
            else
            {
                List<CDOTAModifierBuffTableEntry> list = new List<CDOTAModifierBuffTableEntry>();
                list.Add(mod);
                _modifiersForEntity.Add(mod.parent, list);
            }
        }
    }
}