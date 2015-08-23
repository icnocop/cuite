using System.IO;
using System.Windows.Input;
using Sut.PeripheralInputTest.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sut.PeripheralInputTest
{
    [CodedUITest]
#if DEBUG
    [DeploymentItem(@"..\..\..\Sut.PeripheralInput\bin\Debug")]
#else
    [DeploymentItem(@"..\..\..\Sut.PeripheralInput\bin\Release")]
#endif
    public class KeyboardTest
    {
        private const string ApplicationFileName = "Sut.PeripheralInput.exe";

        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            string applicationFilePath = Path.Combine(TestContext.DeploymentDirectory, ApplicationFileName);
            ApplicationUnderTest.Launch(applicationFilePath);

            mainScreen = new MainScreen();
        }

        [TestMethod]
        public void SendText()
        {
            // Arrange
            string input = "CUITe keyboard test";
            string expected = input;

            // Act
            mainScreen.KeyboardResult.SendKeys(input);
            
            // Assert
            Assert.AreEqual(expected, mainScreen.KeyboardResult.Text);
        }

        [TestMethod]
        public void SendTextWithModifier()
        {
            // Arrange
            string input = "cuite keyboard test";
            string expected = "CUITE KEYBOARD TEST";

            // Act
            mainScreen.KeyboardResult.SendKeys(input, ModifierKeys.Shift);

            // Assert
            Assert.AreEqual(expected, mainScreen.KeyboardResult.Text);
        }

        [TestMethod]
        public void PressAndReleaseModifierKeys()
        {
            // Arrange
            string input = "cuite keyboard test";
            string expected = "CUITE KEYBOARD TEST";

            // Act
            mainScreen.KeyboardResult.PressModifierKeys(ModifierKeys.Shift);
            mainScreen.KeyboardResult.SendKeys(input);
            mainScreen.KeyboardResult.ReleaseModifierKeys(ModifierKeys.Shift);

            // Assert
            Assert.AreEqual(expected, mainScreen.KeyboardResult.Text);
        }


        [TestMethod]
        public void HoldModifierKeys()
        {
            // Arrange
            string input = "cuite keyboard test";
            string expected = "CUITE KEYBOARD TEST";

            // Act
            using (mainScreen.KeyboardResult.HoldModifierKeys(ModifierKeys.Shift))
            {
                mainScreen.KeyboardResult.SendKeys(input);
            }

            // Assert
            Assert.AreEqual(expected, mainScreen.KeyboardResult.Text);
        }

        [TestMethod]
        public void SendTextAfterHoldingModifierKeys()
        {
            // Arrange
            string input = "CUITe keyboard test";
            string expected = input;

            using (mainScreen.KeyboardResult.HoldModifierKeys(ModifierKeys.Shift))
            {
            }

            // Act
            mainScreen.KeyboardResult.SendKeys(input);

            // Assert
            Assert.AreEqual(expected, mainScreen.KeyboardResult.Text);
        }
    }
}