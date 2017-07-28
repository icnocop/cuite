using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// Class Configurator Test
    /// </summary>
    /// <seealso cref="CUITeTest.SearchConfigurations.BaseConfiguratorTest" />
    [TestClass]
    public class ClassConfiguratorTest : BaseConfiguratorTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassConfiguratorTest"/> class.
        /// </summary>
        public ClassConfiguratorTest()
            : base(typeof(ClassConfigurator), "Class", "SomeClass")
        {
        }
    }
}