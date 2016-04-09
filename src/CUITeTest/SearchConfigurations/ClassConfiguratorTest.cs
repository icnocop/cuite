using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [TestClass]
    public class ClassConfiguratorTest : BaseConfiguratorTest
    {
        public ClassConfiguratorTest()
            : base(typeof(ClassConfigurator), "Class", "SomeClass")
        {
        }
    }
}