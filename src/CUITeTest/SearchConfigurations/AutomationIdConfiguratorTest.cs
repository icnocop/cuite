using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [TestClass]
    public class AutomationIdConfiguratorTest : BaseConfiguratorTest
    {
        public AutomationIdConfiguratorTest()
            : base(typeof(AutomationIdConfigurator), "AutomationId", "SomeId")
        {
        }
    }
}