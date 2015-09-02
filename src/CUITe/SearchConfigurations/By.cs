using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    public sealed class By
    {
        private readonly List<ISearchPropertiesConfigurator> configurators; 

        private By()
        {
            configurators = new List<ISearchPropertiesConfigurator>();
        }

        public static By SearchProperties(string searchProperties)
        {
            var by = new By();
            by.configurators.Add(new SearchPropertiesConfigurator(searchProperties));
            return by;
        }

        internal PropertyExpressionCollection InternalSearchProperties
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