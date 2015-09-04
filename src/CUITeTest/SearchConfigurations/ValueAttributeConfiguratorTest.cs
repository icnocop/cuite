using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class ValueAttributeConfiguratorTest
    {
        [TestMethod]
        public void ConfigureStrict()
        {
            // Arrange
            var configurator = new ValueAttributeConfigurator("SomeValue", PropertyExpressionOperator.EqualTo);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeValue", searchProperties.Find("ValueAttribute").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("ValueAttribute").PropertyOperator);
        }

        [TestMethod]
        public void ConfigureLoose()
        {
            // Arrange
            var configurator = new ValueAttributeConfigurator("SomeValue", PropertyExpressionOperator.Contains);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeValue", searchProperties.Find("ValueAttribute").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.Contains, searchProperties.Find("ValueAttribute").PropertyOperator);
        }
    }
}