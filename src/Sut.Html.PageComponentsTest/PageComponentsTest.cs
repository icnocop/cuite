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
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);
                
                // Assert
                Assert.IsTrue(mainPage.UpperLeft.CheckBoxExists);
            }
        }

        [TestMethod]
        public void RebasedUpperLeft()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedUpperLeft.CheckBoxExists);
            }
        }

        [TestMethod]
        public void UpperRight()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.UpperRight.CheckBoxExists);
            }
        }

        [TestMethod]
        public void RebasedUpperRight()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedUpperRight.CheckBoxExists);
            }
        }

        [TestMethod]
        public void LowerLeft()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.LowerLeft.RadioButtonExists);
            }
        }

        [TestMethod]
        public void RebasedLowerLeft()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedLowerLeft.RadioButtonExists);
            }
        }

        [TestMethod]
        public void LowerRight()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.LowerRight.RadioButtonExists);
            }
        }

        [TestMethod]
        public void RebasedLowerRight()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

                // Assert
                Assert.IsTrue(mainPage.RebasedLowerRight.RadioButtonExists);
            }
        }

        [TestMethod]
        public void Browser()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                var mainPage = Page.Launch<MainPage>(webPage.FilePath);

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

        #region Helper properties

        private static string Content
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
                          <div id=""lowerdiv"">
                            <input type=""radio"" id=""lowerleft"">Lower left</input>
                            <input type=""radio"" id=""lowerright"">Lower right</input>
                          </div>
                        </body>
                      </html>";
            }
        }

        #endregion
    }
}