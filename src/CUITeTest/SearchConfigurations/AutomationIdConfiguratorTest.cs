using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class AutomationIdConfiguratorTest
    {
        [TestMethod]
        public void Configure()
        {
            // Arrange
            var configurator = new AutomationIdConfigurator("SomeId");
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeId", searchProperties.Find("AutomationId").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("AutomationId").PropertyOperator);
        }
    }
}