using System.IO;
using System.Windows.Forms;
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
    public class MouseTest
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

        #region Click

        [TestMethod]
        public void LeftClick()
        {
            // Act
            mainScreen.MouseClickText.Click();

            // Assert
            Assert.AreEqual("Left click", mainScreen.MouseClickResult.Text);
        }

        [TestMethod]
        public void MiddleClick()
        {
            // Act
            mainScreen.MouseClickText.Click(MouseButtons.Middle);

            // Assert
            Assert.AreEqual("Middle click", mainScreen.MouseClickResult.Text);
        }

        [TestMethod]
        public void RightClick()
        {
            // Act
            mainScreen.MouseClickText.Click(MouseButtons.Right);

            // Assert
            Assert.AreEqual("Right click", mainScreen.MouseClickResult.Text);
        }
        
        [TestMethod]
        public void XButton1Click()
        {
            // Act
            mainScreen.MouseClickText.Click(MouseButtons.XButton1);

            // Assert
            Assert.AreEqual("XButton1 click", mainScreen.MouseClickResult.Text);
        }

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

        [TestMethod]
        public void LeftDoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick();

            // Assert
            Assert.AreEqual("Left double click", mainScreen.MouseClickResult.Text);
        }

        [TestMethod]
        public void MiddleDoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick(MouseButtons.Middle);

            // Assert
            Assert.AreEqual("Middle double click", mainScreen.MouseClickResult.Text);
        }

        [TestMethod]
        public void RightDoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick(MouseButtons.Right);

            // Assert
            Assert.AreEqual("Right double click", mainScreen.MouseClickResult.Text);
        }

        [TestMethod]
        public void XButton1DoubleClick()
        {
            // Act
            mainScreen.MouseClickText.DoubleClick(MouseButtons.XButton1);

            // Assert
            Assert.AreEqual("XButton1 double click", mainScreen.MouseClickResult.Text);
        }

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

        [TestMethod]
        public void ClickWithAltModifier()
        {
            // Act
            mainScreen.MouseClickText.Click(ModifierKeys.Alt);

            // Assert
            Assert.AreEqual("Left click with Alt", mainScreen.MouseClickResult.Text);
        }

        [TestMethod]
        public void ClickWithControlModifier()
        {
            // Act
            mainScreen.MouseClickText.Click(ModifierKeys.Control);

            // Assert
            Assert.AreEqual("Left click with Control", mainScreen.MouseClickResult.Text);
        }

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