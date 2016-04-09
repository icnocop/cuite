using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about classes.
    /// </summary>
    internal class ClassConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassConfigurator"/> class.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ClassConfigurator(string @class, PropertyExpressionOperator conditionOperator)
            : base(HtmlControl.PropertyNames.Class, @class, conditionOperator)
        {
        }
    }
}