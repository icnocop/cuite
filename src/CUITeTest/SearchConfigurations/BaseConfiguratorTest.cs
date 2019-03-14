using System;
using System.Reflection;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// Base Configurator Test
    /// </summary>
    [TestClass]
    public abstract class BaseConfiguratorTest
    {
        private readonly Type type;
        private readonly string propertyName;
        private readonly string propertyValue;

        private const BindingFlags BindingFlags = System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseConfiguratorTest"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="propertyName">Name of the property.</param>
        /// <param name="propertyValue">The property value.</param>
        /// <exception cref="ArgumentException">Type must inherit from ISearchConfigurator - type</exception>
        protected BaseConfiguratorTest(Type type, string propertyName, string propertyValue)
        {
            if (!typeof(ISearchConfigurator).IsAssignableFrom(type))
            {
                throw new ArgumentException("Type must inherit from ISearchConfigurator", "type");
            }

            this.type = type;
            this.propertyName = propertyName;
            this.propertyValue = propertyValue;
        }

        /// <summary>
        /// Configure strict.
        /// </summary>
        [TestMethod]
        public void ConfigureStrict()
        {
            // Arrange
            var configurator = (ISearchConfigurator)Activator.CreateInstance(this.type, BindingFlags, null, new object[]{ this.propertyValue, PropertyExpressionOperator.EqualTo }, null);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual(this.propertyValue, searchProperties.Find(this.propertyName).PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, searchProperties.Find(this.propertyName).PropertyOperator);
        }

        /// <summary>
        /// Configure loose.
        /// </summary>
        [TestMethod]
        public void ConfigureLoose()
        {
            // Arrange
            var configurator = (ISearchConfigurator)Activator.CreateInstance(this.type, BindingFlags, null, new object[]{ this.propertyValue, PropertyExpressionOperator.Contains }, null);
            var searchProperties = new PropertyExpressionCollection();

            // Act
            configurator.Configure(searchProperties);

            // Assert
            Assert.AreEqual(1, searchProperties.Count);
            Assert.AreEqual(this.propertyValue, searchProperties.Find(this.propertyName).PropertyValue);
            Assert.AreEqual(PropertyExpressionOperator.Contains, searchProperties.Find(this.propertyName).PropertyOperator);
        }
    }
}