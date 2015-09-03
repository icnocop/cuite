﻿using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about automation
    /// ids.
    /// </summary>
    internal class AutomationIdConfigurator : ISearchPropertiesConfigurator
    {
        private readonly string automationId;

        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationIdConfigurator"/> class.
        /// </summary>
        /// <param name="automationId">The automation id.</param>
        internal AutomationIdConfigurator(string automationId)
        {
            if (automationId == null)
                throw new ArgumentNullException("automationId");

            this.automationId = automationId;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public void Configure(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            searchProperties.Add(WpfControl.PropertyNames.AutomationId, automationId);
        }
    }
}