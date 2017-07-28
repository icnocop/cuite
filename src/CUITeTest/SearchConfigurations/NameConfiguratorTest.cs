using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// Name Configurator Test
    /// </summary>
    /// <seealso cref="CUITeTest.SearchConfigurations.BaseConfiguratorTest" />
    [TestClass]
    public class NameConfiguratorTest : BaseConfiguratorTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameConfiguratorTest"/> class.
        /// </summary>
        public NameConfiguratorTest()
            : base(typeof(NameConfigurator), "Name", "SomeName")
        {
        }
    }
}