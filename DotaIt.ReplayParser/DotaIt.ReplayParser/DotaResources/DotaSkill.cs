namespace DotaIt.ReplayParser.DotaResources
{
    /// <summary>
    ///     The dota skill.
    /// </summary>
    public class DotaSkill
    {
        #region Fields

        /// <summary>
        /// The _name.
        /// </summary>
        private string _name = string.Empty;

        private int _curLevel = -1;

        #endregion

        #region Public Properties

        public int CurLevel
        {
            get
            {
                return this._curLevel;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }

        #endregion
    }
}