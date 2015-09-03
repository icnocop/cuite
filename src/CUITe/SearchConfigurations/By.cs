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
        /// Prevents a default instance of the <see cref="By"/> class from being created.
        /// </summary>
        private By()
        {
            configurators = new List<ISearchPropertiesConfigurator>();
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified automation id.
        /// </summary>
        /// <param name="automationId">The automation id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By AutomationId(string automationId)
        {
            var by = new By();
            by.configurators.Add(new AutomationIdConfigurator(automationId));
            return by;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Id(string id)
        {
            var by = new By();
            by.configurators.Add(new IdConfigurator(id));
            return by;
        }

        /// <summary>
        /// Adds a mechanism to find controls by specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// The mechanisms by how particular instances of <see cref="UITestControl"/> are found in
        /// the UI.
        /// </returns>
        public static By Name(string name)
        {
            var by = new By();
            by.configurators.Add(new NameConfigurator(name));
            return by;
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
        public static By SearchProperties(string searchProperties)
        {
            var by = new By();
            by.configurators.Add(new SearchPropertiesConfigurator(searchProperties));
            return by;
        }

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