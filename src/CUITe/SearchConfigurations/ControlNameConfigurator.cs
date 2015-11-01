using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about control
    /// names.
    /// </summary>
    internal class ControlNameConfigurator : SearchConfigurator
    {
        private readonly string controlName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlNameConfigurator"/> class.
        /// </summary>
        /// <param name="controlName">The control name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ControlNameConfigurator(string controlName, PropertyExpressionOperator conditionOperator)
            : base(conditionOperator)
        {
            if (controlName == null)
                throw new ArgumentNullException("controlName");

            this.controlName = controlName;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public override void Configure(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            searchProperties.Add(WinControl.PropertyNames.ControlName, controlName, ConditionOperator);
        }
    }
}