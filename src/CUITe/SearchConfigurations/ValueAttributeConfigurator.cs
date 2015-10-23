using System;
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
        private readonly string valueAttribute;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueAttributeConfigurator"/> class.
        /// </summary>
        /// <param name="valueAttribute">The value attribute.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal ValueAttributeConfigurator(string valueAttribute, PropertyExpressionOperator conditionOperator)
            : base(conditionOperator)
        {
            if (valueAttribute == null)
                throw new ArgumentNullException("valueAttribute");

            this.valueAttribute = valueAttribute;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public override void Configure(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            searchProperties.Add(HtmlControl.PropertyNames.ValueAttribute, valueAttribute, ConditionOperator);
        }
    }
}