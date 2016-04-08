using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [TestClass]
    public class ControlIdConfiguratorTest : BaseConfiguratorTest
    {
        public ControlIdConfiguratorTest()
            : base(typeof(ControlIdConfigurator), "ControlId", "SomeControlId")
        {
        }
    }
}