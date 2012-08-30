using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CUITe.Controls.HtmlControls;
using Sample_CUITeTestProject.ObjectRepository;
using System.IO;
using Microsoft.VisualStudio.TestTools.UITesting;
using System.Diagnostics;

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
            CUITe_BrowserWindow.Launch(CurrentDirectory + "/TestHtmlPage.html");

            //Act
            BrowserWindow bWin = CUITe_BrowserWindow.FromProcess(Process.GetProcessesByName("iexplore").Single(x => !string.IsNullOrEmpty(x.MainWindowTitle)));

            //Assert
            Assert.AreEqual("A Test - Windows Internet Explorer", bWin.Title);

            bWin.Close();
        }

        [TestMethod]
        public void Launch_GetWindowTitle_Succeeds()
        {
            //Arrange
            string url = CurrentDirectory + "/TestHtmlPage.html";
            string windowTitle = "A Test";
            string fullWindowTitle = string.Format("{0} - Windows Internet Explorer", windowTitle);

            //Act
            TestHtmlPage window = CUITe_BrowserWindow.Launch<TestHtmlPage>(url);

            //Assert
            Assert.AreEqual(fullWindowTitle, window.Title);

            window.Close();
        }

        [TestMethod]
        [WorkItem(608)]
        public void GenericGet_WithHtmlControls_GetsControlsDynamically()
        {
            //Arrange
            CUITe_BrowserWindow bWin = CUITe_BrowserWindow.Launch("http://mail.google.com", "Gmail: Email from Google");

            //Act
            bWin.Get<CUITe_HtmlEdit>("Id=Email").SetText("xyz@gmail.com");
            bWin.Get<CUITe_HtmlPassword>("Id=Password").SetText("MyPa$$Word");
            bWin.Get<CUITe_HtmlInputButton>("Id=signIn").Click();
            bWin.Close();
        }

        [TestMethod]
        public void GetBrowserWindow_WithDynamicWindowTitle_CanGetNewWindowTitle()
        {
            string page1GenericWindowTitle = "window title 1";
            string page1FullWindowTitle = "window title 1 - Windows Internet Explorer";

            //Arrange
            DynamicBrowserWindowTitleRepository home = CUITe_BrowserWindow.Launch<DynamicBrowserWindowTitleRepository>(CurrentDirectory + "/DynamicBrowserWindowTitle.html");

            home.btnGoToPage1.Click();

            //Act
            DynamicBrowserWindowTitleRepository page1 = CUITe_DynamicBrowserWindow.GetBrowserWindow<DynamicBrowserWindowTitleRepository>(page1GenericWindowTitle);

            //Assert
            Assert.AreEqual(page1FullWindowTitle, page1.Title);

            page1.Close();
        }

        [TestMethod]
        [WorkItem(607)]
        public void GetBrowserWindow_WithDynamicWindowTitle_CanInteractWithWindow()
        {
            //Arrange
            string page2GenericWindowTitle = "window title 2";
            string page2DynamicGenericWindowTitle = "the window title changed";
            string page2DynamicFullWindowTitle = "the window title changed - Windows Internet Explorer";
            string homePageGenericWindowTitle = "Clicking the buttons changes the window title";
            string homePageFullWindowTitle = "Clicking the buttons changes the window title - Windows Internet Explorer";

            DynamicBrowserWindowTitleRepository home = CUITe_BrowserWindow.Launch<DynamicBrowserWindowTitleRepository>(CurrentDirectory + "/DynamicBrowserWindowTitle.html");

            home.btnGoToPage2.Click();

            DynamicBrowserWindowTitleRepository page2 = CUITe_DynamicBrowserWindow.GetBrowserWindow<DynamicBrowserWindowTitleRepository>(page2GenericWindowTitle);

            page2.btnChangeWindowTitle.Click();

            //Checkpoint
            Assert.AreEqual(page2DynamicFullWindowTitle, page2.Title);

            //Act
            page2 = CUITe_DynamicBrowserWindow.GetBrowserWindow<DynamicBrowserWindowTitleRepository>(page2DynamicGenericWindowTitle);

            page2.btnGoToHomePage.Click();

            page2.SetWindowTitle(homePageGenericWindowTitle);

            //Assert
            Assert.AreEqual(homePageFullWindowTitle, page2.Title);

            page2.Close();
        }
    }
}
