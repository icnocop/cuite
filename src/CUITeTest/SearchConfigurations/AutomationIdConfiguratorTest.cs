using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// Automation Id Configurator Test
    /// </summary>
    /// <seealso cref="CUITeTest.SearchConfigurations.BaseConfiguratorTest" />
    [TestClass]
    public class AutomationIdConfiguratorTest : BaseConfiguratorTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationIdConfiguratorTest"/> class.
        /// </summary>
        public AutomationIdConfiguratorTest()
            : base(typeof(AutomationIdConfigurator), "AutomationId", "SomeId")
        {
        }
    }
}