using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    [CodedUITest]
    public class ByTest
    {
        [TestMethod]
        public void AutomationId()
        {
            // Act
            By configuration = By.AutomationId("SomeAutomationId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AutomationIdContains()
        {
            // Act
            By configuration = By.AutomationIdContains("SomeAutomationId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void Class()
        {
            // Act
            By configuration = By.Class("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void ClassContains()
        {
            // Act
            By configuration = By.ClassContains("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndClass()
        {
            // Act
            By configuration = new By().AndClass("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndClassContains()
        {
            // Act
            By configuration = new By().AndClassContains("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void Id()
        {
            // Act
            By configuration = By.Id("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void IdContains()
        {
            // Act
            By configuration = By.IdContains("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndId()
        {
            // Act
            By configuration = new By().AndId("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndIdContains()
        {
            // Act
            By configuration = new By().AndIdContains("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void Name()
        {
            // Act
            By configuration = By.Name("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void NameContains()
        {
            // Act
            By configuration = By.NameContains("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndName()
        {
            // Act
            By configuration = new By().AndName("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndNameContains()
        {
            // Act
            By configuration = new By().AndNameContains("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void SearchProperties()
        {
            // Act
            By configuration = By.SearchProperties("SomeName=SomeValue");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void AndSearchProperties()
        {
            // Act
            By configuration = new By().AndSearchProperties("SomeName=SomeValue");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void TagName()
        {
            // Act
            By configuration = By.TagName("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void TagNameContains()
        {
            // Act
            By configuration = By.TagNameContains("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndTagName()
        {
            // Act
            By configuration = new By().AndTagName("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndTagNameContains()
        {
            // Act
            By configuration = new By().AndTagNameContains("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void ValueAttribute()
        {
            // Act
            By configuration = By.ValueAttribute("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void ValueAttributeContains()
        {
            // Act
            By configuration = By.ValueAttributeContains("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndValueAttribute()
        {
            // Act
            By configuration = new By().AndValueAttribute("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        [TestMethod]
        public void AndValueAttributeContains()
        {
            // Act
            By configuration = new By().AndValueAttributeContains("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }
    }
}