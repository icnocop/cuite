using CUITe.PageObjects;
using Sut.HtmlTest.PageObjects;
using TestHelpers;

namespace Sut.HtmlTest
{
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Browser window tests
    /// </summary>
    [CodedUITest]
    [DeploymentItem("TestHtmlPage.html")]
    [DeploymentItem("DynamicBrowserWindowTitle.html")]
    [DeploymentItem("DynamicBrowserWindowTitle.1.html")]
    [DeploymentItem("DynamicBrowserWindowTitle.2.html")]
    public class BrowserWindowTests
    {
        /// <summary>
        /// The current directory
        /// </summary>
        private readonly string currentDirectory = Directory.GetCurrentDirectory();

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for the current test run.
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global; MsTest requirements
        // ReSharper disable once MemberCanBePrivate.Global; MsTest requirements
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Runs after each test.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            Trace.WriteLine(string.Format("Test Results Directory: {0}", TestContext.TestResultsDirectory));
        }

        /// <summary>
        /// Gets the window title from the process.
        /// </summary>
        [TestMethod]
        public void FromProcess_GetWindowTitle_Succeeds()
        {
            // Arrange
            using (var webPage = new TempWebPage(
@"<html>
    <head>
        <title>A Test</title>
    </head>
    <body/>
</html>"))
            {
                BrowserWindow.Launch(webPage.FilePath);

                // Act
                BrowserWindow browserWindow = BrowserWindow.FromProcess(Process.GetProcessesByName("iexplore").Single(x => !string.IsNullOrEmpty(x.MainWindowTitle)));

                // Assert
                Assert.IsTrue(browserWindow.Title.Contains("A Test"), browserWindow.Title);

                browserWindow.Close();
            }
        }

        /// <summary>
        /// Gets the window title from launched browser window.
        /// </summary>
        [TestMethod]
        public void Launch_GetWindowTitle_Succeeds()
        {
            // Arrange
            string url = currentDirectory + "/TestHtmlPage.html";
            string windowTitle = "A Test";

            // Act
            BrowserWindow window = BrowserWindow.Launch(url);
            
            // Assert
            Assert.IsTrue(window.Title.Contains(windowTitle));

            window.Close();
        }

        /// <summary>
        /// Gets the HTML document from browser window can get outer HTML property.
        /// </summary>
        [TestMethod]
        public void GetHtmlDocument_FromBrowserWindow_CanGetOuterHtmlProperty()
        {
            // Arrange
            var page = Page.Launch<TestHtmlPage>(currentDirectory + "/TestHtmlPage.html");

            // Act
            var doc = page.Document;

            // Assert
            // if Visual Studio Team System for Testers is installed, the vsttFireTimer attribute is automatically injected within the body element for some unknown reason
            // so just check for <body
            const string expected = "<body";

            string outerHtml = doc.SourceControl.GetProperty("OuterHtml").ToString().Trim();

            Assert.AreEqual(expected, outerHtml.Substring(0, expected.Length), true, outerHtml);
        }

        /// <summary>
        /// Find all browser windows from process name can get URI and title.
        /// </summary>
        [TestMethod]
        public void FromProcess_FindAllBrowserWindows_CanGetUriAndTitle()
        {
            Process[] processes = Process.GetProcessesByName("iexplore");
            foreach (Process process in processes)
            {
                if (string.IsNullOrEmpty(process.MainWindowTitle))
                {
                    continue;
                }

                BrowserWindow browserWindow = BrowserWindow.FromProcess(process);

                Trace.WriteLine(string.Format("Found browser window: {0} {1}", browserWindow.Uri, browserWindow.Title));
            }
        }
    }
}
