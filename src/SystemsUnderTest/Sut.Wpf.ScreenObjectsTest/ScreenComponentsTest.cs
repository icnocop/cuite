using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.ScreenObjectsTest.ScreenObjects;

namespace Sut.Wpf.ScreenObjectsTest
{
    /// <summary>
    /// Screen Objects Test
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.Wpf.ScreenObjects.exe")]
    public class ScreenObjectsTest
    {
        private const string ApplicationFilePath = "Sut.Wpf.ScreenObjects.exe";
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
        /// Upper left.
        /// </summary>
        [TestMethod]
        public void UpperLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.UpperLeft.CheckBoxExists);
        }

        /// <summary>
        /// Rebased upper left.
        /// </summary>
        [TestMethod]
        public void RebasedUpperLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedUpperLeft.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedUpperLeft.CheckBoxExists);
        }

        /// <summary>
        /// Upper right.
        /// </summary>
        [TestMethod]
        public void UpperRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.UpperRight.CheckBoxExists);
        }

        /// <summary>
        /// Rebased upper right.
        /// </summary>
        [TestMethod]
        public void RebasedUpperRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedUpperRight.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedUpperRight.CheckBoxExists);
        }

        /// <summary>
        /// Lower left.
        /// </summary>
        [TestMethod]
        public void LowerLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerLeft.RadioButtonExists);
        }

        /// <summary>
        /// Rebased lower left.
        /// </summary>
        [TestMethod]
        public void RebasedLowerLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedLowerLeft.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedLowerLeft.RadioButtonExists);
        }

        /// <summary>
        /// Lower right.
        /// </summary>
        [TestMethod]
        public void LowerRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerRight.RadioButtonExists);
        }

        /// <summary>
        /// Rebased lower right.
        /// </summary>
        [TestMethod]
        public void RebasedLowerRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedLowerRight.Self.Exists);
            Assert.IsTrue(mainScreen.RebasedLowerRight.RadioButtonExists);
        }

        /// <summary>
        /// Application.
        /// </summary>
        [TestMethod]
        public void Application()
        {
            // Act
            ApplicationUnderTest actual = mainScreen.Application;

            // Assert
            Assert.AreEqual(mainScreen.UpperLeft.Application, actual);
            Assert.AreEqual(mainScreen.RebasedUpperLeft.Application, actual);
            Assert.AreEqual(mainScreen.UpperRight.Application, actual);
            Assert.AreEqual(mainScreen.RebasedUpperRight.Application, actual);
            Assert.AreEqual(mainScreen.LowerLeft.Application, actual);
            Assert.AreEqual(mainScreen.RebasedLowerLeft.Application, actual);
            Assert.AreEqual(mainScreen.LowerRight.Application, actual);
            Assert.AreEqual(mainScreen.RebasedLowerRight.Application, actual);
        }

        /// <summary>
        /// Self.
        /// </summary>
        [TestMethod]
        public void Self()
        {
            // Assert
            Assert.IsTrue(mainScreen.Self.WaitForControlExist());
            Assert.IsTrue(mainScreen.Self.Exists);
            Assert.IsTrue(mainScreen.Self.Visible);
        }

        /// <summary>
        /// From process.
        /// </summary>
        [TestMethod]
        public void FromProcess()
        {
            //Act
            mainScreen = Screen.FromProcess<MainScreen>(mainScreen.Application.Process);

            //Assert
            Assert.IsTrue(mainScreen.Application.Exists);
        }

        /// <summary>
        /// Navigates to modal dialog.
        /// </summary>
        [TestMethod]
        public void NavigateToModalDialog()
        {
            // Act
            var dialogScreen = mainScreen.MiddleScreenObject.NavigateToModalDialogScreen();

            // Assert
            Assert.IsTrue(dialogScreen.CloseButton.Exists);
        }

        /// <summary>
        /// Navigates to non modal dialog.
        /// </summary>
        [TestMethod]
        public void NavigateToNonModalDialog()
        {
            // Act
            var dialogScreen = mainScreen.MiddleScreenObject.NavigateToNonModalDialogScreen();

            // Assert
            Assert.IsTrue(dialogScreen.CloseButton.Exists);
        }

        /// <summary>
        /// Button in dialog with identical content.
        /// </summary>
        [TestMethod]
        public void ButtonInDialogWithIdenticalContent()
        {
            // Arrange
            var identicalButtonContentScreen = mainScreen.MiddleScreenObject.NavigateToIdenticalButtonContentScreen();
            
            // Act
            identicalButtonContentScreen.ClickIdenticalButton();

            // Assert
            Assert.IsFalse(identicalButtonContentScreen.Self.Exists);
        }
    }
}