using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// Control Id Configurator Test
    /// </summary>
    /// <seealso cref="CUITeTest.SearchConfigurations.BaseConfiguratorTest" />
    [TestClass]
    public class ControlIdConfiguratorTest : BaseConfiguratorTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlIdConfiguratorTest"/> class.
        /// </summary>
        public ControlIdConfiguratorTest()
            : base(typeof(ControlIdConfigurator), "ControlId", "SomeControlId")
        {
        }
    }
}