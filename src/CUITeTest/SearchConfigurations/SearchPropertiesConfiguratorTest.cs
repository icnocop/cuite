using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class SearchPropertiesConfiguratorTest
    {
        [TestMethod]
        public void ConfigureStrictSearchProperty()
        {
            // Arrange
            var configurator = new SearchPropertiesConfigurator("Name=Value");
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("Value", searchProperties.Find("Name").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("Name").PropertyOperator);
        }

        [TestMethod]
        public void ConfigureStrictSearchProperties()
        {
            // Arrange
            var configurator = new SearchPropertiesConfigurator("Name1=Value1;Name2=Value2");
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(2, searchProperties.Count);
            Assert.AreEqual("Value1", searchProperties.Find("Name1").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("Name1").PropertyOperator);
            Assert.AreEqual("Value2", searchProperties.Find("Name2").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("Name2").PropertyOperator);
        }

        [TestMethod]
        public void ConfigureLooseSearchProperty()
        {
            // Arrange
            var configurator = new SearchPropertiesConfigurator("Name~Value");
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("Value", searchProperties.Find("Name").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.Contains, searchProperties.Find("Name").PropertyOperator);
        }
    }
}