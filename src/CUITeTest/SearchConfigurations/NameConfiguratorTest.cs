using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class NameConfiguratorTest
    {
        [TestMethod]
        public void ConfigureStrict()
        {
            // Arrange
            var configurator = new NameConfigurator("SomeName", PropertyExpressionOperator.EqualTo);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeName", searchProperties.Find("Name").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("Name").PropertyOperator);
        }

        [TestMethod]
        public void ConfigureLoose()
        {
            // Arrange
            var configurator = new NameConfigurator("SomeName", PropertyExpressionOperator.Contains);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeName", searchProperties.Find("Name").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.Contains, searchProperties.Find("Name").PropertyOperator);
        }
    }
}