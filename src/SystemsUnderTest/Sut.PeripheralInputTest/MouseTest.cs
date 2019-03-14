using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.PeripheralInputTest.ScreenObjects;
using Screen = CUITe.ScreenObjects.Screen;

namespace Sut.PeripheralInputTest
{
    /// <summary>
    /// Mouse Test
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.PeripheralInput.exe")]
    public class MouseTest
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

        #region Click

        /// <summary>
        /// Left click.
        /// </summary>
        [TestMethod]
        public void LeftClick()
        {
            // Act
            mainScreen.MouseClickText.Click();

            // Assert
            Assert.AreEqual("Left click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// Middle click.
        /// </summary>
        [TestMethod]
        public void MiddleClick()
        {
            // Act
            mainScreen.MouseClickText.Click(MouseButtons.Middle);

            // Assert
            Assert.AreEqual("Middle click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// Right click.
        /// </summary>
        [TestMethod]
        public void RightClick()
        {
            // Act
            mainScreen.MouseClickText.Click(MouseButtons.Right);

            // Assert
            Assert.AreEqual("Right click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// X button 1 click.
        /// </summary>
        [TestMethod]
        public void XButton1Click()
        {
            // Act
            mainScreen.MouseClickText.Click(MouseButtons.XButton1);

            // Assert
            Assert.AreEqual("XButton1 click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// X button 2 click.
        /// </summary>
        [TestMethod]
        public void XButton2Click()
        {
            // Act
            mainScreen.MouseClickText.Click(MouseButtons.XButton2);

            // Assert
            Assert.AreEqual("XButton2 click", mainScreen.MouseClickResult.Text);
        }

        #endregion

        #region Double click

        /// <summary>
        /// Left double click.
        /// </summary>
        [TestMethod]
        public void LeftDoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick();

            // Assert
            Assert.AreEqual("Left double click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// Middle double click.
        /// </summary>
        [TestMethod]
        public void MiddleDoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick(MouseButtons.Middle);

            // Assert
            Assert.AreEqual("Middle double click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// Right double click.
        /// </summary>
        [TestMethod]
        public void RightDoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick(MouseButtons.Right);

            // Assert
            Assert.AreEqual("Right double click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// X button 1 double click.
        /// </summary>
        [TestMethod]
        public void XButton1DoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick(MouseButtons.XButton1);

            // Assert
            Assert.AreEqual("XButton1 double click", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// X button 2 double click.
        /// </summary>
        [TestMethod]
        public void XButton2DoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick(MouseButtons.XButton2);

            // Assert
            Assert.AreEqual("XButton2 double click", mainScreen.MouseClickResult.Text);
        }

        #endregion

        #region Click with modifier

        /// <summary>
        /// Click with alt modifier.
        /// </summary>
        [TestMethod]
        public void ClickWithAltModifier()
        {
            // Act
            mainScreen.MouseClickText.Click(ModifierKeys.Alt);

            // Assert
            Assert.AreEqual("Left click with Alt", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// Click with control modifier.
        /// </summary>
        [TestMethod]
        public void ClickWithControlModifier()
        {
            // Act
            mainScreen.MouseClickText.Click(ModifierKeys.Control);

            // Assert
            Assert.AreEqual("Left click with Control", mainScreen.MouseClickResult.Text);
        }

        /// <summary>
        /// Click with shift modifier.
        /// </summary>
        [TestMethod]
        public void ClickWithShiftModifier()
        {
            // Act
            mainScreen.MouseClickText.Click(ModifierKeys.Shift);

            // Assert
            Assert.AreEqual("Left click with Shift", mainScreen.MouseClickResult.Text);
        }

        #endregion
    }
}