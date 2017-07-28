using System.IO;
using System.Threading;
using CassiniDev;
using CUITe.Controls;
using CUITe.PageObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Silverlight.PageObjectsTest.PageObjects;

namespace Sut.Silverlight.PageObjectsTest
{
    /// <summary>
    /// Page Objects Test
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.Silverlight.PageObjects.html")]
    [DeploymentItem("Sut.Silverlight.PageObjects.xap")]
    public class PageObjectsTest
    {
        private static readonly CassiniDevServer WebServer = new CassiniDevServer();

        private MainPage mainPage;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            WebServer.StartServer(Directory.GetCurrentDirectory());

            // always wait until controls are ready
            ControlBase.IsControlReadinessAwaitedByDefault = true;
        }

        /// <summary>
        /// Cleans up the class.
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            WebServer.StopServer();
        }

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mainPage = Page.Launch<MainPage>(WebServer.RootUrl + "Sut.Silverlight.PageObjects.html");
        }

        /// <summary>
        /// Upper left.
        /// </summary>
        [TestMethod]
        public void UpperLeft()
        {
            bool checkBoxExists = false;

            // this test randomly fails because its usually run first; so try several times
            for (int i = 0; i < 10; i++)
            {
                if (mainPage.UpperLeft.CheckBoxExists)
                {
                    checkBoxExists = true;
                    break;
                }
                else
                {
                    Thread.Sleep(1000);

                    mainPage = Page.Get<MainPage>();
                }
            }

            // Assert
            Assert.IsTrue(checkBoxExists);
        }

        /// <summary>
        /// Rebased upper left.
        /// </summary>
        [TestMethod]
        public void RebasedUpperLeft()
        {
            // Assert
            Assert.IsTrue(mainPage.RebasedUpperLeft.Self.Exists);
            Assert.IsTrue(mainPage.RebasedUpperLeft.CheckBoxExists);
        }

        /// <summary>
        /// Upper right.
        /// </summary>
        [TestMethod]
        public void UpperRight()
        {
            // Assert
            Assert.IsTrue(mainPage.UpperRight.CheckBoxExists);
        }

        /// <summary>
        /// Rebased upper right.
        /// </summary>
        [TestMethod]
        public void RebasedUpperRight()
        {
            // Assert
            Assert.IsTrue(mainPage.RebasedUpperRight.Self.Exists);
            Assert.IsTrue(mainPage.RebasedUpperRight.CheckBoxExists);
        }

        /// <summary>
        /// Lower left.
        /// </summary>
        [TestMethod]
        public void LowerLeft()
        {
            // Assert
            Assert.IsTrue(mainPage.LowerLeft.RadioButtonExists);
        }

        /// <summary>
        /// Rebased lower left.
        /// </summary>
        [TestMethod]
        public void RebasedLowerLeft()
        {
            // Assert
            Assert.IsTrue(mainPage.RebasedLowerLeft.Self.Exists);
            Assert.IsTrue(mainPage.RebasedLowerLeft.RadioButtonExists);
        }

        /// <summary>
        /// Lower right.
        /// </summary>
        [TestMethod]
        public void LowerRight()
        {
            // Assert
            Assert.IsTrue(mainPage.LowerRight.RadioButtonExists);
        }

        /// <summary>
        /// Rebased lower right.
        /// </summary>
        [TestMethod]
        public void RebasedLowerRight()
        {
            // Assert
            Assert.IsTrue(mainPage.RebasedLowerRight.Self.Exists);
            Assert.IsTrue(mainPage.RebasedLowerRight.RadioButtonExists);
        }

        /// <summary>
        /// Browser.
        /// </summary>
        [TestMethod]
        public void Browser()
        {
            // Act
            BrowserWindow actual = mainPage.Browser;

            // Assert
            Assert.AreEqual(mainPage.UpperLeft.Browser, actual);
            Assert.AreEqual(mainPage.RebasedUpperLeft.Browser, actual);
            Assert.AreEqual(mainPage.UpperRight.Browser, actual);
            Assert.AreEqual(mainPage.RebasedUpperRight.Browser, actual);
            Assert.AreEqual(mainPage.LowerLeft.Browser, actual);
            Assert.AreEqual(mainPage.RebasedLowerLeft.Browser, actual);
            Assert.AreEqual(mainPage.LowerRight.Browser, actual);
            Assert.AreEqual(mainPage.RebasedLowerRight.Browser, actual);
        }

        /// <summary>
        /// Self.
        /// </summary>
        [TestMethod]
        public void Self()
        {
            // Assert
            Assert.IsTrue(mainPage.Self.WaitForControlExist());
            Assert.IsTrue(mainPage.Self.Exists);
            Assert.IsTrue(mainPage.Self.Enabled);
        }

        /// <summary>
        /// Navigates to dialog.
        /// </summary>
        [TestMethod]
        public void NavigateToDialog()
        {
            // Act
            var dialogScreen = mainPage.MiddlePageObject.NavigateToDialogPage();

            // Assert
            Assert.IsTrue(dialogScreen.CloseButtonExists);
        }
    }
}