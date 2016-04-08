using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [TestClass]
    public class ClassNameConfiguratorTest : BaseConfiguratorTest
    {
        public ClassNameConfiguratorTest()
            : base(typeof(ClassNameConfigurator), "ClassName", "SomeClassName")
        {
        }
    }
}