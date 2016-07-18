using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about the instance.
    /// </summary>
    internal class InstanceConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceConfigurator"/> class.
        /// </summary>
        /// <param name="instance">The control instance (1-based).</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal InstanceConfigurator(string instance, PropertyExpressionOperator conditionOperator)
            : base(WinControl.PropertyNames.Instance, instance, conditionOperator)
        {
        }
    }
}