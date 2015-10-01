using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.ScreenComponentsTest.Mappings;

namespace Sut.Wpf.ScreenComponentsTest
{
    [CodedUITest]
    public class ScreenComponentsTest
    {
#if DEBUG
        private const string ApplicationFilePath = @"..\..\..\Sut.Wpf.ScreenComponents\bin\Debug\Sut.Wpf.ScreenComponents.exe";
#else
        private const string ApplicationFilePath = @"..\..\..\Sut.Wpf.ScreenComponents\bin\Release\Sut.Wpf.ScreenComponents.exe";
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
        public void UpperRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.UpperRight.CheckBoxExists);
        }

        [TestMethod]
        public void LowerLeft()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerLeft.RadioButtonExists);
        }

        [TestMethod]
        public void LowerRight()
        {
            // Assert
            Assert.IsTrue(mainScreen.LowerRight.RadioButtonExists);
        }
    }
}