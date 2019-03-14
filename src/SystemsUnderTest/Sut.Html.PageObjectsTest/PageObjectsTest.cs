using System.IO;
using CUITe.PageObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Html.PageObjectsTest.PageObjects;
using TestHelpers;

namespace Sut.Html.PageObjectsTest
{
    /// <summary>
    /// Page Object Tests
    /// </summary>
    [CodedUITest]
    public class PageObjectsTest
    {
        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Upper left.
        /// </summary>
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

        /// <summary>
        /// Rebased upper left.
        /// </summary>
        [TestMethod]
        public void RebasedUpperLeft()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedUpperLeft.Self.Exists);
                Assert.IsTrue(mainPage.RebasedUpperLeft.CheckBoxExists);
            }
        }

        /// <summary>
        /// Upper right.
        /// </summary>
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

        /// <summary>
        /// Rebased upper right.
        /// </summary>
        [TestMethod]
        public void RebasedUpperRight()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedUpperRight.Self.Exists);
                Assert.IsTrue(mainPage.RebasedUpperRight.CheckBoxExists);
            }
        }

        /// <summary>
        /// Lower left.
        /// </summary>
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

        /// <summary>
        /// Rebased lower left.
        /// </summary>
        [TestMethod]
        public void RebasedLowerLeft()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedLowerLeft.Self.Exists);
                Assert.IsTrue(mainPage.RebasedLowerLeft.RadioButtonExists);
            }
        }

        /// <summary>
        /// Lower right.
        /// </summary>
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

        /// <summary>
        /// Rebased lower right.
        /// </summary>
        [TestMethod]
        public void RebasedLowerRight()
        {
            using (var homePage = new TempWebPage(Home))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedLowerRight.Self.Exists);
                Assert.IsTrue(mainPage.RebasedLowerRight.RadioButtonExists);
            }
        }

        /// <summary>
        /// Browser.
        /// </summary>
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

        /// <summary>
        /// Navigate to non modal dialog.
        /// </summary>
        [TestMethod]
        public void NavigateToNonModalDialog()
        {
            using (var aboutPage = new TempWebPage(About))
            using (var homePage = new TempWebPage(string.Format(Home, Path.GetFileName(aboutPage.FilePath))))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(homePage.FilePath);

                // Act
                var dialogScreen = mainPage.MiddlePageObject.NavigateToAboutPage();

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
                        <head>
                        </head>
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
                        <head>
                        </head>
                        <body>
                          <p id=""framework"">This test is executed by CUITe.</p>
                        </body>
                      </html>";
            }
        }

        #endregion
    }
}