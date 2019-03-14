using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CUITeTest.SearchConfigurations
{
    /// <summary>
    /// By Test
    /// </summary>
    [CodedUITest]
    public class ByTest
    {
        /// <summary>
        /// Automation identifier.
        /// </summary>
        [TestMethod]
        public void AutomationId()
        {
            // Act
            By configuration = By.AutomationId("SomeAutomationId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Automation identifier contains.
        /// </summary>
        [TestMethod]
        public void AutomationIdContains()
        {
            // Act
            By configuration = By.AutomationIdContains("SomeAutomationId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Class.
        /// </summary>
        [TestMethod]
        public void Class()
        {
            // Act
            By configuration = By.Class("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Class contains.
        /// </summary>
        [TestMethod]
        public void ClassContains()
        {
            // Act
            By configuration = By.ClassContains("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And class.
        /// </summary>
        [TestMethod]
        public void AndClass()
        {
            // Act
            By configuration = new By().AndClass("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And class contains.
        /// </summary>
        [TestMethod]
        public void AndClassContains()
        {
            // Act
            By configuration = new By().AndClassContains("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Control name.
        /// </summary>
        [TestMethod]
        public void ControlName()
        {
            // Act
            By configuration = By.ControlName("SomeControlName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Control name contains.
        /// </summary>
        [TestMethod]
        public void ControlNameContains()
        {
            // Act
            By configuration = By.ControlNameContains("SomeControlName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And control name.
        /// </summary>
        [TestMethod]
        public void AndControlName()
        {
            // Act
            By configuration = new By().AndControlName("SomeControlName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And control name contains.
        /// </summary>
        [TestMethod]
        public void AndControlNameContains()
        {
            // Act
            By configuration = new By().AndControlNameContains("SomeControlName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Identifiers.
        /// </summary>
        [TestMethod]
        public void Id()
        {
            // Act
            By configuration = By.Id("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Identifier contains.
        /// </summary>
        [TestMethod]
        public void IdContains()
        {
            // Act
            By configuration = By.IdContains("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And identifier.
        /// </summary>
        [TestMethod]
        public void AndId()
        {
            // Act
            By configuration = new By().AndId("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And identifier contains.
        /// </summary>
        [TestMethod]
        public void AndIdContains()
        {
            // Act
            By configuration = new By().AndIdContains("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Name.
        /// </summary>
        [TestMethod]
        public void Name()
        {
            // Act
            By configuration = By.Name("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Name contains.
        /// </summary>
        [TestMethod]
        public void NameContains()
        {
            // Act
            By configuration = By.NameContains("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And name.
        /// </summary>
        [TestMethod]
        public void AndName()
        {
            // Act
            By configuration = new By().AndName("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And name contains.
        /// </summary>
        [TestMethod]
        public void AndNameContains()
        {
            // Act
            By configuration = new By().AndNameContains("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Search properties.
        /// </summary>
        [TestMethod]
        public void SearchProperties()
        {
            // Act
            By configuration = By.SearchProperties("SomeName=SomeValue");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        /// <summary>
        /// And search properties.
        /// </summary>
        [TestMethod]
        public void AndSearchProperties()
        {
            // Act
            By configuration = new By().AndSearchProperties("SomeName=SomeValue");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        /// <summary>
        /// Tag name.
        /// </summary>
        [TestMethod]
        public void TagName()
        {
            // Act
            By configuration = By.TagName("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Tag name contains.
        /// </summary>
        [TestMethod]
        public void TagNameContains()
        {
            // Act
            By configuration = By.TagNameContains("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And tag name.
        /// </summary>
        [TestMethod]
        public void AndTagName()
        {
            // Act
            By configuration = new By().AndTagName("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And tag name contains.
        /// </summary>
        [TestMethod]
        public void AndTagNameContains()
        {
            // Act
            By configuration = new By().AndTagNameContains("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Value attribute.
        /// </summary>
        [TestMethod]
        public void ValueAttribute()
        {
            // Act
            By configuration = By.ValueAttribute("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Value attribute contains.
        /// </summary>
        [TestMethod]
        public void ValueAttributeContains()
        {
            // Act
            By configuration = By.ValueAttributeContains("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And value attribute.
        /// </summary>
        [TestMethod]
        public void AndValueAttribute()
        {
            // Act
            By configuration = new By().AndValueAttribute("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And value attribute contains.
        /// </summary>
        [TestMethod]
        public void AndValueAttributeContains()
        {
            // Act
            By configuration = new By().AndValueAttributeContains("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Class name.
        /// </summary>
        [TestMethod]
        public void ClassName()
        {
            // Act
            By configuration = By.ClassName("SomeClassName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Class name contains.
        /// </summary>
        [TestMethod]
        public void ClassNameContains()
        {
            // Act
            By configuration = By.ClassNameContains("SomeClassName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And class name.
        /// </summary>
        [TestMethod]
        public void AndClassName()
        {
            // Act
            By configuration = new By().AndClassName("SomeClassName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And class name contains.
        /// </summary>
        [TestMethod]
        public void AndClassNameContains()
        {
            // Act
            By configuration = new By().AndClassNameContains("SomeClassName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Control identifier.
        /// </summary>
        [TestMethod]
        public void ControlId()
        {
            // Act
            By configuration = By.ControlId("SomeControlId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// Control identifier contains.
        /// </summary>
        [TestMethod]
        public void ControlIdContains()
        {
            // Act
            By configuration = By.ControlIdContains("SomeControlId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And control identifier.
        /// </summary>
        [TestMethod]
        public void AndControlId()
        {
            // Act
            By configuration = new By().AndControlId("SomeControlId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.EqualTo, configuration.Configuration.First().PropertyOperator);
        }

        /// <summary>
        /// And control identifier contains.
        /// </summary>
        [TestMethod]
        public void AndControlIdContains()
        {
            // Act
            By configuration = new By().AndControlIdContains("SomeControlId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
            Assert.AreEqual(PropertyExpressionOperator.Contains, configuration.Configuration.First().PropertyOperator);
        }
    }
}