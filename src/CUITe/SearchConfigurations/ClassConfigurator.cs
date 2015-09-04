using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about classes.
    /// </summary>
    internal class ClassConfigurator : ISearchPropertiesConfigurator
    {
        private readonly string @class;
        private readonly PropertyExpressionOperator conditionOperator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassConfigurator"/> class.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ClassConfigurator(string @class, PropertyExpressionOperator conditionOperator)
        {
            if (@class == null)
                throw new ArgumentNullException("class");

            this.@class = @class;
            this.conditionOperator = conditionOperator;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public void Configure(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            searchProperties.Add(HtmlControl.PropertyNames.Class, @class, conditionOperator);
        }
    }
}