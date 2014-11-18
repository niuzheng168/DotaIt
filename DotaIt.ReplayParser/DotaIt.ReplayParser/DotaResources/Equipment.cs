namespace DotaIt.ReplayParser.DotaResources
{
    using System.Collections.Generic;

    /// <summary>
    ///     The equipment.
    /// </summary>
    public class Equipment
    {
        #region Fields

        /// <summary>
        /// The _name.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// The formulas.
        /// </summary>
        private List<Equipment> formulas = new List<Equipment>();

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the formulas.
        /// </summary>
        public List<Equipment> Formulas
        {
            get
            {
                return this.formulas;
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