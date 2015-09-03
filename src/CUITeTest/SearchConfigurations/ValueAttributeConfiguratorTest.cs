using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class ValueAttributeConfiguratorTest
    {
        [TestMethod]
        public void Configure()
        {
            // Arrange
            var configurator = new ValueAttributeConfigurator("SomeValue");
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual("SomeValue", searchProperties.Find("ValueAttribute").PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find("ValueAttribute").PropertyOperator);
        }
    }
}