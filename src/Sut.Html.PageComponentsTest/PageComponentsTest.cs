using System.IO;
using CUITe.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Html.PageComponentsTest.ObjectRepository;
using TestHelpers;

namespace Sut.Html.PageComponentsTest
{
    [CodedUITest]
    public class PageComponentsTest
    {
        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void UpperLeft()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);
                
                // Assert
                Assert.IsTrue(mainPage.UpperLeft.CheckBoxExists);
            }
        }

        [TestMethod]
        public void RebasedUpperLeft()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedUpperLeft.CheckBoxExists);
            }
        }

        [TestMethod]
        public void UpperRight()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.UpperRight.CheckBoxExists);
            }
        }

        [TestMethod]
        public void RebasedUpperRight()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedUpperRight.CheckBoxExists);
            }
        }

        [TestMethod]
        public void LowerLeft()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.LowerLeft.RadioButtonExists);
            }
        }

        [TestMethod]
        public void RebasedLowerLeft()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedLowerLeft.RadioButtonExists);
            }
        }

        [TestMethod]
        public void LowerRight()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.LowerRight.RadioButtonExists);
            }
        }

        [TestMethod]
        public void RebasedLowerRight()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedLowerRight.RadioButtonExists);
            }
        }

        [TestMethod]
        public void Browser()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

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
        }

        [TestMethod]
        public void NavigateToNonModalDialog()
        {
            using (var aboutPage = new TempWebPage(About))
            using (var homePage = new TempWebPage(string.Format(Home, Path.GetFileName(aboutPage.FilePath))))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Act
                var dialogScreen = mainPage.MiddleComponent.NavigateToAboutPage();

                // Assert
                Assert.IsTrue(dialogScreen.FrameworkMessageExists);
            }
        }

        #region Helper properties

        private static string Home
        {
            get
            {
                return
                    @"<html>
                        <body>
                          <div id=""upperdiv"">
                            <input type=""checkbox"" id=""upperleft"">Upper left</input>
                            <input type=""checkbox"" id=""upperright"">Upper right</input>
                          </div>
                          <button id=""navigatetoabout"" onclick=""location.href='{0}';"">About</button>
                          <div id=""lowerdiv"">
                            <input type=""radio"" id=""lowerleft"">Lower left</input>
                            <input type=""radio"" id=""lowerright"">Lower right</input>
                          </div>
                        </body>
                      </html>";
            }
        }

        private static string About
        {
            get
            {
                return
                    @"<html>
                        <body>
                          <p id=""framework"">This test is executed by CUITe.</p>
                        </body>
                      </html>";
            }
        }

        #endregion
    }
}