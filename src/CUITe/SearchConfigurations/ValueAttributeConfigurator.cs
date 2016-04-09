using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about value
    /// attributes.
    /// </summary>
    internal class ValueAttributeConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueAttributeConfigurator"/> class.
        /// </summary>
        /// <param name="valueAttribute">The value attribute.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ValueAttributeConfigurator(string valueAttribute, PropertyExpressionOperator conditionOperator)
            : base(HtmlControl.PropertyNames.ValueAttribute, valueAttribute, conditionOperator)
        {
        }
    }
}