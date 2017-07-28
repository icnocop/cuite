using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// Control Name Configurator Test
    /// </summary>
    /// <seealso cref="CUITeTest.SearchConfigurations.BaseConfiguratorTest" />
    [TestClass]
    public class ControlNameConfiguratorTest : BaseConfiguratorTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlNameConfiguratorTest"/> class.
        /// </summary>
        public ControlNameConfiguratorTest()
            : base(typeof(ControlNameConfigurator), "ControlName", "SomeControlName")
        {
        }
    }
}