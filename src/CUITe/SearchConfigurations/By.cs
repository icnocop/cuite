using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Class providing mechanisms by how particular instances of <see cref="UITestControl"/> are
    /// found in the UI.
    /// </summary>
    public sealed class By
    {
        private readonly List<ISearchPropertiesConfigurator> configurators;

        /// <summary>
        /// Initializes a new instance of the <see cref="By"/> class.
        /// </summary>
        internal By()
        {
            configurators = new List<ISearchPropertiesConfigurator>();
        }

        #region Automation Id

        /// <summary>
        /// Adds a mechanism to find controls by specified automation id.
        /// </summary>
        /// <param name="automationId">The automation id.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By AutomationId(
            string automationId,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            var by = new By();
            by.configurators.Add(new AutomationIdConfigurator(automationId, conditionOperator));
            return by;
        }

        #endregion

        #region Class

        /// <summary>
        /// Adds a mechanism to find controls by specified class.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Class(
            string @class,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            return new By().AndClass(@class, conditionOperator);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified class.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndClass(
            string @class,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            configurators.Add(new ClassConfigurator(@class, conditionOperator));
            return this;
        }

        #endregion

        #region Id

        /// <summary>
        /// Adds a mechanism to find controls by specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Id(
            string id,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            return new By().AndId(id, conditionOperator);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndId(
            string id,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            configurators.Add(new IdConfigurator(id, conditionOperator));
            return this;
        }

        #endregion

        #region Name

        /// <summary>
        /// Adds a mechanism to find controls by specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Name(
            string name,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            return new By().AndName(name, conditionOperator);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndName(
            string name,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            configurators.Add(new NameConfigurator(name, conditionOperator));
            return this;
        }

        #endregion

        #region Search Properties

        /// <summary>
        /// Adds a mechanism to find controls by specified search properties.
        /// </summary>
        /// <param name="searchProperties">
        /// The search properties in the 'Name1=Value1;Name2=Value2' format.
        /// For example use the strict format of 'Id=firstname' for a control that has an Id of
        /// 'firstname', or the loose format of 'Id~firstname' for a control that has an Id that
        /// contains 'firstname'.
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By SearchProperties(string searchProperties)
        {
            return new By().AndSearchProperties(searchProperties);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified search properties.
        /// </summary>
        /// <param name="searchProperties">
        /// The search properties in the 'Name1=Value1;Name2=Value2' format.
        /// For example use the strict format of 'Id=firstname' for a control that has an Id of
        /// 'firstname', or the loose format of 'Id~firstname' for a control that has an Id that
        /// contains 'firstname'.
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndSearchProperties(string searchProperties)
        {
            configurators.Add(new SearchPropertiesConfigurator(searchProperties));
            return this;
        }

        #endregion

        #region Tag Name

        /// <summary>
        /// Adds a mechanism to find controls by specified tag name.
        /// </summary>
        /// <param name="tagName">The tag name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By TagName(
            string tagName,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            return new By().AndTagName(tagName, conditionOperator);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified name.
        /// </summary>
        /// <param name="tagName">The tag name.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndTagName(
            string tagName,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            configurators.Add(new TagNameConfigurator(tagName, conditionOperator));
            return this;
        }

        #endregion

        #region Value Attribute

        /// <summary>
        /// Adds a mechanism to find controls by specified value attribute.
        /// </summary>
        /// <param name="valueAttribute">The value attribute.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By ValueAttribute(
            string valueAttribute,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            return new By().AndValueAttribute(valueAttribute, conditionOperator);
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified value attribute.
        /// </summary>
        /// <param name="valueAttribute">The value attribute.</param>
        /// <param name="conditionOperator">
        /// The operator to use to compare the values (either the values are equal or the property
        /// value contains the provided property value).
        /// </param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public By AndValueAttribute(
            string valueAttribute,
            PropertyExpressionOperator conditionOperator = PropertyExpressionOperator.EqualTo)
        {
            configurators.Add(new ValueAttributeConfigurator(valueAttribute, conditionOperator));
            return this;
        }

        #endregion

        /// <summary>
        /// Gets the search properties configuration of this instance.
        /// </summary>
        internal PropertyExpressionCollection Configuration
        {
            get
            {
                var searchProperties = new PropertyExpressionCollection();

                foreach (ISearchPropertiesConfigurator configurator in configurators)
                {
                    configurator.Configure(searchProperties);
                }

                return searchProperties;
            }
        }
    }
}