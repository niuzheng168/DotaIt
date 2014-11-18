namespace DotaIt.ReplayParser.DotaResources
{
    using System.Collections.Generic;

    /// <summary>
    ///     The dota hero.
    /// </summary>
    public class DotaHero
    {
        #region Fields

        /// <summary>
        /// The _equipments.
        /// </summary>
        private List<Equipment> _equipments = new List<Equipment>(6);

        /// <summary>
        /// The _name.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// The _skills.
        /// </summary>
        private List<DotaSkill> _skills = new List<DotaSkill>();

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the equipments.
        /// </summary>
        public List<Equipment> Equipments
        {
            get
            {
                return this._equipments;
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

        /// <summary>
        /// Gets the skills.
        /// </summary>
        public List<DotaSkill> Skills
        {
            get
            {
                return this._skills;
            }
        }

        #endregion
    }
}