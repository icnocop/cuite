using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Html.PageComponentsTest.Mappings;
using Test;

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
                BrowserWindow browserWindow = BrowserWindow.Launch(webPage.FilePath);
                var mainPage = new MainPage(browserWindow);
                
                // Assert
                Assert.IsTrue(mainPage.UpperLeft.CheckBoxExists);
            }
        }

        [TestMethod]
        public void UpperRight()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                BrowserWindow browserWindow = BrowserWindow.Launch(webPage.FilePath);
                var mainPage = new MainPage(browserWindow);

                // Assert
                Assert.IsTrue(mainPage.UpperRight.CheckBoxExists);
            }
        }

        [TestMethod]
        public void LowerLeft()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                BrowserWindow browserWindow = BrowserWindow.Launch(webPage.FilePath);
                var mainPage = new MainPage(browserWindow);

                // Assert
                Assert.IsTrue(mainPage.LowerLeft.RadioButtonExists);
            }
        }

        [TestMethod]
        public void LowerRight()
        {
            using (var webPage = new TempWebPage(Content))
            {
                // Arrange
                BrowserWindow browserWindow = BrowserWindow.Launch(webPage.FilePath);
                var mainPage = new MainPage(browserWindow);

                // Assert
                Assert.IsTrue(mainPage.LowerRight.RadioButtonExists);
            }
        }

        private static string Content
        {
            get
            {
                return
                    @"<html>
                        <body>
                          <div>
                            <input type=""checkbox"" id=""upperleft"">Upper left</input>
                            <input type=""checkbox"" id=""upperright"">Upper right</input>
                          </div>
                          <div>
                            <input type=""radio"" id=""lowerleft"">Lower left</input>
                            <input type=""radio"" id=""lowerright"">Lower right</input>
                          </div>
                        </body>
                      </html>";
            }
        }
    }
}