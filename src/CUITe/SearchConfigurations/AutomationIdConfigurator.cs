using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about automation
    /// ids.
    /// </summary>
    internal class AutomationIdConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationIdConfigurator"/> class.
        /// </summary>
        /// <param name="automationId">The automation id.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal AutomationIdConfigurator(string automationId, PropertyExpressionOperator conditionOperator)
            : base(WpfControl.PropertyNames.AutomationId, automationId, conditionOperator)
        {
        }
    }
}