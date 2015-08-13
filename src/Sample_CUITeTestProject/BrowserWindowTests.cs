using System.Diagnostics;
using System.IO;
using System.Linq;
using CUITe.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample_CUITeTestProject.ObjectRepository;

namespace Sample_CUITeTestProject
{
    [CodedUITest]
    [DeploymentItem(@"Sample_CUITeTestProject\TestHtmlPage.html")]
    [DeploymentItem(@"Sample_CUITeTestProject\DynamicBrowserWindowTitle.html")]
    [DeploymentItem(@"Sample_CUITeTestProject\DynamicBrowserWindowTitle.1.html")]
    [DeploymentItem(@"Sample_CUITeTestProject\DynamicBrowserWindowTitle.2.html")]
    public class BrowserWindowTests
    {
        private string CurrentDirectory = Directory.GetCurrentDirectory();

        [TestMethod]
        public void FromProcess_GetWindowTitle_Succeeds()
        {
            //Arrange
            using (TempFile tempFile = new TempFile(
@"<html>
    <head>
        <title>A Test</title>
    </head>
    <body/>
</html>"))
            {
                BrowserWindowUnderTest.Launch(tempFile.FilePath);

                //Act
                BrowserWindow bWin = BrowserWindowUnderTest.FromProcess(Process.GetProcessesByName("iexplore").Single(x => !string.IsNullOrEmpty(x.MainWindowTitle)));

                //Assert
                Assert.IsTrue(bWin.Title.Contains("A Test"), bWin.Title);

                bWin.Close();
            }
        }

        [TestMethod]
        public void Launch_GetWindowTitle_Succeeds()
        {
            //Arrange
            string url = CurrentDirectory + "/TestHtmlPage.html";
            string windowTitle = "A Test";

            //Act
            TestHtmlPage window = BrowserWindowUnderTest.Launch<TestHtmlPage>(url);

            //Assert
            Assert.IsTrue(window.Title.Contains(windowTitle), window.Title);

            window.Close();
        }

        [Ignore] // TODO: use known html
        [TestMethod]
        [WorkItem(608)]
        public void GenericGet_WithHtmlControls_GetsControlsDynamically()
        {
            //Arrange
            BrowserWindowUnderTest bWin = BrowserWindowUnderTest.Launch("http://mail.google.com", "Gmail: Email from Google");

            //Act
            bWin.Get<HtmlEdit>("Id=Email").SetText("xyz@gmail.com");
            bWin.Get<HtmlPassword>("Id=Password").SetText("MyPa$$Word");
            bWin.Get<HtmlInputButton>("Id=signIn").Click();
            bWin.Close();
        }

        [TestMethod]
        public void GetBrowserWindow_WithDynamicWindowTitle_CanGetNewWindowTitle()
        {
            string page1GenericWindowTitle = "window title 1";

            //Arrange
            DynamicBrowserWindowTitleRepository home = BrowserWindowUnderTest.Launch<DynamicBrowserWindowTitleRepository>(CurrentDirectory + "/DynamicBrowserWindowTitle.html");

            home.btnGoToPage1.Click();

            //Act
            DynamicBrowserWindowTitleRepository page1 = DynamicBrowserWindowUnderTest.GetBrowserWindow<DynamicBrowserWindowTitleRepository>(page1GenericWindowTitle);

            //Assert
            Assert.IsTrue(page1.Title.Contains(page1GenericWindowTitle), page1.Title);

            page1.Close();
        }

        [TestMethod]
        [WorkItem(607)]
        public void GetBrowserWindow_WithDynamicWindowTitle_CanInteractWithWindow()
        {
            //Arrange
            string page2GenericWindowTitle = "window title 2";
            string page2DynamicGenericWindowTitle = "the window title changed";
            string homePageGenericWindowTitle = "Clicking the buttons changes the window title";

            DynamicBrowserWindowTitleRepository home = BrowserWindowUnderTest.Launch<DynamicBrowserWindowTitleRepository>(CurrentDirectory + "/DynamicBrowserWindowTitle.html");

            home.btnGoToPage2.Click();

            DynamicBrowserWindowTitleRepository page2 = DynamicBrowserWindowUnderTest.GetBrowserWindow<DynamicBrowserWindowTitleRepository>(page2GenericWindowTitle);

            page2.btnChangeWindowTitle.Click();

            //Checkpoint
            Assert.IsTrue(page2.Title.Contains(page2DynamicGenericWindowTitle), page2.Title);

            //Act
            page2 = DynamicBrowserWindowUnderTest.GetBrowserWindow<DynamicBrowserWindowTitleRepository>(page2DynamicGenericWindowTitle);

            page2.btnGoToHomePage.Click();

            page2.SetWindowTitle(homePageGenericWindowTitle);

            //Assert
            Assert.IsTrue(page2.Title.Contains(homePageGenericWindowTitle), page2.Title);

            page2.Close();
        }

        [TestMethod]
        public void GetHtmlDocument_FromBrowserWindow_CanGetOuterHtmlProperty()
        {
            //Arrange
            TestHtmlPage window = BrowserWindowUnderTest.Launch<TestHtmlPage>(CurrentDirectory + "/TestHtmlPage.html");

            //Act
            var doc = window.Get<HtmlDocument>();

            //Assert
            const string expected = "<body>";

            Assert.AreEqual(expected, doc.UnWrap().GetProperty("OuterHtml").ToString().Substring(0, expected.Length), true);

            window.Close();
        }

        [TestMethod]
        public void CloseBrowserWindow_UsingLaunchedBrowserWindow_Succeeds()
        {
            TestHtmlPage window = BrowserWindowUnderTest.Launch<TestHtmlPage>(CurrentDirectory + "/TestHtmlPage.html");

            window.Close();
        }

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

                BrowserWindow bWin = BrowserWindowUnderTest.FromProcess(process);

                Trace.WriteLine(string.Format("Found browser window: {0} {1}", bWin.Uri, bWin.Title));
            }
        }
    }
}
