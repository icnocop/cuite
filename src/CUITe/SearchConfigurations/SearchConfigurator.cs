using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Base class of all search configurators.
    /// </summary>
    internal abstract class SearchConfigurator : ISearchConfigurator
    {
        private readonly string propertyName;
        private readonly string propertyValue;
        private readonly PropertyExpressionOperator conditionOperator;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigurator" /> class.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <param name="conditionOperator">The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).</param>
        protected SearchConfigurator(string propertyName, string propertyValue, PropertyExpressionOperator conditionOperator)
        {
            if (propertyName == null)
                throw new ArgumentNullException("propertyName");

            if (propertyValue == null)
                throw new ArgumentNullException("propertyValue");

            this.propertyName = propertyName;
            this.propertyValue = propertyValue;
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

            searchProperties.Add(this.propertyName, this.propertyValue, this.conditionOperator);
        }
    }
}