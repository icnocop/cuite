using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class TagNameConfiguratorTest
    {
        [TestMethod]
        public void ConfigureStrict()
        {
            // Arrange
            var configurator = new TagNameConfigurator("SomeTagName", PropertyExpressionOperator.EqualTo);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeTagName", searchProperties.Find("TagName").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("TagName").PropertyOperator);
        }

        [TestMethod]
        public void ConfigureLoose()
        {
            // Arrange
            var configurator = new TagNameConfigurator("SomeTagName", PropertyExpressionOperator.Contains);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeTagName", searchProperties.Find("TagName").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.Contains, searchProperties.Find("TagName").PropertyOperator);
        }
    }
}