using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about class names.
    /// </summary>
    internal class ClassNameConfigurator : SearchConfigurator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlNameConfigurator"/> class.
        /// </summary>
        /// <param name="className">The class name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ClassNameConfigurator(string className, PropertyExpressionOperator conditionOperator)
            : base(UITestControl.PropertyNames.ClassName, className, conditionOperator)
        {
        }
    }
}