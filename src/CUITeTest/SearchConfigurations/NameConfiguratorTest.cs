using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [TestClass]
    public class NameConfiguratorTest : BaseConfiguratorTest
    {
        public NameConfiguratorTest()
            : base(typeof(NameConfigurator), "Name", "SomeName")
        {
        }
    }
}