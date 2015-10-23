using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about automation
    /// ids.
    /// </summary>
    internal class AutomationIdConfigurator : SearchConfigurator
    {
        private readonly string automationId;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationIdConfigurator"/> class.
        /// </summary>
        /// <param name="automationId">The automation id.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal AutomationIdConfigurator(string automationId, PropertyExpressionOperator conditionOperator)
            : base(conditionOperator)
        {
            if (automationId == null)
                throw new ArgumentNullException("automationId");

            this.automationId = automationId;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public override void Configure(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            searchProperties.Add(WpfControl.PropertyNames.AutomationId, automationId, ConditionOperator);
        }
    }
}