using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [TestClass]
    public class ControlNameConfiguratorTest : BaseConfiguratorTest
    {
        public ControlNameConfiguratorTest()
            : base(typeof(ControlNameConfigurator), "ControlName", "SomeControlName")
        {
        }
    }
}