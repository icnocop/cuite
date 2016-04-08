using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [TestClass]
    public class IdConfiguratorTest : BaseConfiguratorTest
    {
        public IdConfiguratorTest()
            : base(typeof(IdConfigurator), "Id", "SomeId")
        {
        }
    }
}