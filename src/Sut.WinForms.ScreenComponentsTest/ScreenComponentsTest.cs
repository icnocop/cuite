using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.WinForms.ScreenComponentsTest.ObjectRepository;

namespace Sut.WinForms.ScreenComponentsTest
{
    /// <summary>
    /// Summary description for ScreenComponentsTest
    /// </summary>
    [CodedUITest]
    public class ScreenComponentsTest
    {
#if DEBUG
        private const string ApplicationFilePath = @"..\..\..\Sut.WinForms.ScreenComponents\bin\Debug\Sut.WinForms.ScreenComponents.exe";
#else
        private const string ApplicationFilePath = @"..\..\..\Sut.WinForms.ScreenComponents\bin\Release\Sut.WinForms.ScreenComponents.exe";
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
            ApplicationUnderTest application = ApplicationUnderTest.Launch(ApplicationFilePath);
            mainScreen = new MainScreen(application);
        }

        [TestMethod]
        public void UpperLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.UpperLeft.CheckBoxExists);
        }

        [TestMethod]
        public void RebasedUpperLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedUpperLeft.CheckBoxExists);
        }

        [TestMethod]
        public void UpperRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.UpperRight.CheckBoxExists);
        }

        [TestMethod]
        public void RebasedUpperRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedUpperRight.CheckBoxExists);
        }

        [TestMethod]
        public void LowerLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerLeft.RadioButtonExists);
        }

        [TestMethod]
        public void RebasedLowerLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedLowerLeft.RadioButtonExists);
        }

        [TestMethod]
        public void LowerRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerRight.RadioButtonExists);
        }

        [TestMethod]
        public void RebasedLowerRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.RebasedLowerRight.RadioButtonExists);
        }
    }
}