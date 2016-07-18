using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about the control type
    /// names.
    /// </summary>
    internal class ControlTypeConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlTypeConfigurator"/> class.
        /// </summary>
        /// <param name="controlType">The control type.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ControlTypeConfigurator(string controlType, PropertyExpressionOperator conditionOperator)
            : base(UITestControl.PropertyNames.ControlType, controlType, conditionOperator)
        {
        }
    }
}