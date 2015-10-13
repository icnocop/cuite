using System.Windows.Input;
using CUITe.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.PeripheralInputTest.ObjectRepository;

namespace Sut.PeripheralInputTest
{
    [CodedUITest]
    public class KeyboardTest
    {
#if DEBUG
        private const string ApplicationFilePath = @"..\..\..\Sut.PeripheralInput\bin\Debug\Sut.PeripheralInput.exe";
#else
        private const string ApplicationFilePath = @"..\..\..\Sut.PeripheralInput\bin\Release\Sut.PeripheralInput.exe";
#endif
        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            mainScreen = Screen.Launch<MainScreen>(ApplicationFilePath);
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