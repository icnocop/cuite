using System.Windows.Input;
using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.PeripheralInputTest.ScreenObjects;

namespace Sut.PeripheralInputTest
{
    /// <summary>
    /// Keyboard Test
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.PeripheralInput.exe")]
    public class KeyboardTest
    {
        private const string ApplicationFilePath = "Sut.PeripheralInput.exe";
        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mainScreen = Screen.Launch<MainScreen>(ApplicationFilePath);
        }

        /// <summary>
        /// Send text.
        /// </summary>
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

        /// <summary>
        /// Send text with modifier.
        /// </summary>
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

        /// <summary>
        /// Press and release modifier keys.
        /// </summary>
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


        /// <summary>
        /// Hold modifier keys.
        /// </summary>
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

        /// <summary>
        /// Send text after holding modifier keys.
        /// </summary>
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