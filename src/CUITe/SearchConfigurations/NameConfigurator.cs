using System;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class capable of configuring a set of search properties with information about names.
    /// </summary>
    internal class NameConfigurator : SearchConfigurator
    {
        private readonly string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="NameConfigurator"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        internal NameConfigurator(string name, PropertyExpressionOperator conditionOperator)
            : base(conditionOperator)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            this.name = name;
        }

        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        public override void Configure(PropertyExpressionCollection searchProperties)
        {
            if (searchProperties == null)
                throw new ArgumentNullException("searchProperties");

            searchProperties.Add(UITestControl.PropertyNames.Name, name, ConditionOperator);
        }
    }
}