using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about ids.
    /// </summary>
    internal class IdConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdConfigurator"/> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal IdConfigurator(string id, PropertyExpressionOperator conditionOperator)
            : base(HtmlControl.PropertyNames.Id, id, conditionOperator)
        {
        }
    }
}