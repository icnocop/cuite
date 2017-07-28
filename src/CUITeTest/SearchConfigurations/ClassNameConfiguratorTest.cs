using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// Class Name Configurator Test
    /// </summary>
    /// <seealso cref="CUITeTest.SearchConfigurations.BaseConfiguratorTest" />
    [TestClass]
    public class ClassNameConfiguratorTest : BaseConfiguratorTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassNameConfiguratorTest"/> class.
        /// </summary>
        public ClassNameConfiguratorTest()
            : base(typeof(ClassNameConfigurator), "ClassName", "SomeClassName")
        {
        }
    }
}