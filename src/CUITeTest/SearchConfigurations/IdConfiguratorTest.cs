using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class IdConfiguratorTest
    {
        [TestMethod]
        public void ConfigureStrict()
        {
            // Arrange
            var configurator = new IdConfigurator("SomeId", PropertyExpressionOperator.EqualTo);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeId", searchProperties.Find("Id").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("Id").PropertyOperator);
        }

        [TestMethod]
        public void ConfigureLoose()
        {
            // Arrange
            var configurator = new IdConfigurator("SomeId", PropertyExpressionOperator.Contains);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeId", searchProperties.Find("Id").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.Contains, searchProperties.Find("Id").PropertyOperator);
        }
    }
}