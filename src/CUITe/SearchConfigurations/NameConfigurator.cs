using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about names.
    /// </summary>
    internal class NameConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameConfigurator"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal NameConfigurator(string name, PropertyExpressionOperator conditionOperator)
            : base(UITestControl.PropertyNames.Name, name, conditionOperator)
        {
        }
    }
}