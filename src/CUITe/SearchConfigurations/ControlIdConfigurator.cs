using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about control ids.
    /// </summary>
    internal class ControlIdConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlNameConfigurator"/> class.
        /// </summary>
        /// <param name="controlId">The control id.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ControlIdConfigurator(string controlId, PropertyExpressionOperator conditionOperator)
            : base(WinControl.PropertyNames.ControlId, controlId, conditionOperator)
        {
        }
    }
}