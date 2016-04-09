using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about tag names.
    /// </summary>
    internal class TagNameConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagNameConfigurator"/> class.
        /// </summary>
        /// <param name="tagName">The tag name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal TagNameConfigurator(string tagName, PropertyExpressionOperator conditionOperator)
            : base(HtmlControl.PropertyNames.TagName, tagName, conditionOperator)
        {
        }
    }
}