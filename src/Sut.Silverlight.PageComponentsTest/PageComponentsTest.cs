using System.IO;
using CassiniDev;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Silverlight.PageComponentsTest.Mappings;

namespace Sut.Silverlight.PageComponentsTest
{
    [CodedUITest]
    [DeploymentItem("Sut.Silverlight.PageComponents.html")]
#if DEBUG
    [DeploymentItem(@"..\..\..\Sut.Silverlight.PageComponents\Bin\Debug\Sut.Silverlight.PageComponents.xap")]
#else
    [DeploymentItem(@"..\..\..\Sut.Silverlight.PageComponents\Bin\Release\Sut.Silverlight.PageComponents.xap")]
#endif
    public class PageComponentsTest
    {
        private static readonly CassiniDevServer WebServer = new CassiniDevServer();
        
        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            WebServer.StartServer(Directory.GetCurrentDirectory(), 8080, "/", "localhost");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            WebServer.StopServer();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            BrowserWindow browserWindow = BrowserWindow.Launch(WebServer.RootUrl + "Sut.Silverlight.PageComponents.html");
            mainScreen = new MainScreen(browserWindow);
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