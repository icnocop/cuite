using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class AutomationIdConfiguratorTest
    {
        [TestMethod]
        public void ConfigureStrict()
        {
            // Arrange
            var configurator = new AutomationIdConfigurator("SomeId", PropertyExpressionOperator.EqualTo);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeId", searchProperties.Find("AutomationId").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("AutomationId").PropertyOperator);
        }

        [TestMethod]
        public void ConfigureLoose()
        {
            // Arrange
            var configurator = new AutomationIdConfigurator("SomeId", PropertyExpressionOperator.Contains);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeId", searchProperties.Find("AutomationId").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.Contains, searchProperties.Find("AutomationId").PropertyOperator);
        }
    }
}