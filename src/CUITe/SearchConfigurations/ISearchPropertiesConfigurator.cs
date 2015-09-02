using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    internal interface ISearchPropertiesConfigurator
    {
        void Configure(PropertyExpressionCollection searchProperties);
    }
}