using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.SearchConfigurations
{
    /// <summary>
    /// Interface capable of configuring a set of search properties according to the rules on the
    /// implemented class.
    /// </summary>
    internal interface ISearchConfigurator
    {
        /// <summary>
        /// Configures the specified search properties.
        /// </summary>
        /// <param name="searchProperties">The search properties.</param>
        void Configure(PropertyExpressionCollection searchProperties);
    }
}