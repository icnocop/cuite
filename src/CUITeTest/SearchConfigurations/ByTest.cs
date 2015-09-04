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
        }

        [TestMethod]
        public void Class()
        {
            // Act
            By configuration = By.Class("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void AndClass()
        {
            // Act
            By configuration = new By().AndClass("SomeClass");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void Id()
        {
            // Act
            By configuration = By.Id("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void AndId()
        {
            // Act
            By configuration = new By().AndId("SomeId");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void Name()
        {
            // Act
            By configuration = By.Name("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void AndName()
        {
            // Act
            By configuration = new By().AndName("SomeName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
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
        }

        [TestMethod]
        public void AndTagName()
        {
            // Act
            By configuration = new By().AndTagName("SomeTagName");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void ValueAttribute()
        {
            // Act
            By configuration = By.ValueAttribute("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }

        [TestMethod]
        public void AndValueAttribute()
        {
            // Act
            By configuration = new By().AndValueAttribute("SomeValueAttribute");

            // Assert
            Assert.AreEqual(1, configuration.Configuration.Count);
        }
    }
}