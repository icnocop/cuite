using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Base class of all search configurators.
    /// </summary>
    internal abstract class SearchConfigurator : ISearchConfigurator
    {
        private readonly PropertyExpressionOperator conditionOperator;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigurator"/> class.
        /// </summary>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        protected SearchConfigurator(PropertyExpressionOperator conditionOperator)
        {
            this.conditionOperator = conditionOperator;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public abstract void Configure(PropertyExpressionCollection searchProperties);

        /// <summary>
        /// Gets the condition operator.
        /// </summary>
        protected PropertyExpressionOperator ConditionOperator
        {
            get { return conditionOperator; }
        }
    }
}