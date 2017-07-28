using System;
using System.IO;
using CassiniDev;
using CUITe.Controls;
using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.SilverlightTest.PageObjects;

namespace Sut.SilverlightTest
{
    /// <summary>
    /// Silverlight Controls Tests
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.Silverlight.html")]
    [DeploymentItem("Sut.Silverlight.xap")]
    public class SilverlightControlTests
    {
        //TODO: the silverlight control must be hosted on a page served through a web server (ex. iis, cassini \ web dev server) because IE 9 may
        //treat web pages differently between http://localhost and file:// (compatibility mode\view)

        private CassiniDevServer WebServer;

        private string PageUrl
        {
            get
            {
                return string.Format("{0}Sut.Silverlight.html", WebServer.RootUrl);
            }
        }

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
#if !VS2010 && !VS2012
            Playback.PlaybackSettings.AlwaysSearchControls = true; // false
#elif !VS2010
            Playback.PlaybackSettings.MaximumRetryCount = 3; // 1
#endif
            Playback.PlaybackSettings.MatchExactHierarchy = false; // false
            Playback.PlaybackSettings.SearchTimeout = 120000; // 120000
            Playback.PlaybackSettings.ShouldSearchFailFast = false; // true
            Playback.PlaybackSettings.SmartMatchOptions = SmartMatchOptions.None; // SmartMatchOptions.Control
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.UIThreadOnly; // .UIThreadOnly
            Playback.PlaybackSettings.WaitForReadyTimeout = 60000; // 60000

            // start the web server for every test because sometimes the web server will stop for whatever reason
            // and display "This page can't be displayed"
            WebServer = new CassiniDevServer();
            WebServer.StartServer(Directory.GetCurrentDirectory());
        }

        /// <summary>
        /// Cleans up the test.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            // stop and dispose the web server if it's running
            if (WebServer != null)
            {
                WebServer.Dispose();
            }
        }

        /// <summary>
        /// Sets the selected date of a date picker.
        /// </summary>
        [TestMethod]
        public void SlButtonAndEditAndDTP_ClickAndSetTextAndSelectedDateAsString_Succeeds()
        {
            BrowserWindow b = BrowserWindow.Launch(PageUrl);
            b.SetFocus();
            SilverlightButton button1 = b.Find<SilverlightButton>(By.AutomationId("button1"));
            button1.WaitForControlExist();
            button1.Click();
            SilverlightEdit oEdit = b.Find<SilverlightEdit>(By.AutomationId("textBox1"));
            oEdit.Text = "asddasdasdasdadasdadasdadadadasd";
            SilverlightDatePicker dp = b.Find<SilverlightDatePicker>(By.AutomationId("datePicker1"));
            dp.SourceControl.SelectedDate = new DateTime(2011, 5, 11);
            b.Close();
        }

        /// <summary>
        /// Gets a Silverlight list page object.
        /// </summary>
        [TestMethod]
        public void SlList_PageObjects_Succeeds()
        {
            var page = Page.Launch<TestPage>(PageUrl);
            page.List.SelectedIndices = new[] { 2 };
            Assert.IsTrue(page.List.SelectedItemsAsString == "Coded UI Test");
        }

        /// <summary>
        /// Selects items of a Silverlight List using an index.
        /// </summary>
        [TestMethod]
        public void SlList_DynamicObjectRecognition_Succeeds()
        {
            BrowserWindow b = BrowserWindow.Launch(PageUrl);
            b.SetFocus();
            SilverlightList oList = b.Find<SilverlightList>(By.AutomationId("listBox1"));
            oList.SelectedIndices = new[] { 2 };
            Assert.IsTrue(oList.SelectedItemsAsString == "Coded UI Test");
            b.Close();
        }

        /// <summary>
        /// Selects items of a Silverlight ComboBox by index.
        /// </summary>
        [TestMethod]
        public void SlComboBox_SelectItem_Succeeds()
        {
            var browserWindow = BrowserWindow.Launch(PageUrl);
            browserWindow.SetFocus();
            var oCombo = browserWindow.Find<SilverlightComboBox>(By.AutomationId("comboBox1"));
            oCombo.SelectIndex(3);
            foreach (UITestControl temp in oCombo.Items)
            {
                Console.WriteLine(temp.Name);
            }
            browserWindow.Close();
        }

        /// <summary>
        /// Selects a Silverlight tab by index.
        /// </summary>
        [TestMethod]
        public void SlTab_SelectedIndex_Succeeds()
        {
            BrowserWindow b = BrowserWindow.Launch(PageUrl);
            b.SetFocus();
            SilverlightTab oTab = b.Find<SilverlightTab>(By.AutomationId("tabControl1"));
            oTab.SelectedIndex= 1;
            Assert.IsTrue(oTab.SourceControl.Items[0].Name == "tabItem1");
            b.Close();
        }

        /// <summary>
        /// Traverses through the children of a Silverlight tab.
        /// </summary>
        [TestMethod]
        public void SlTab_TraverseSiblingsAndChildren_Succeeds()
        {
            BrowserWindow b = BrowserWindow.Launch(PageUrl);
            b.SetFocus();
            SilverlightTab oTab = b.Find<SilverlightTab>(By.AutomationId("tabControl1"));
            oTab.SelectedIndex = 0;
            var btnOK = b.Find<SilverlightButton>(By.AutomationId("OKButtonInTabItem1"));
            ((SilverlightEdit)(btnOK.PreviousSibling)).Text = "blah blah hurray";
            foreach (ControlBase control in oTab.GetChildren())
            {
                if (control.GetType() == typeof(SilverlightEdit))
                {
                    ((SilverlightEdit)control).Text = "Text Changed";
                    break;
                }
            }
            Assert.IsTrue(((SilverlightTab)btnOK.Parent).SelectedItem == "tabItem1");
            b.Close();
        }

        /// <summary>
        /// Clicks a button in a child window.
        /// </summary>
        [TestMethod]
        public void Click_ButtonInChildWindow_Succeeds()
        {
            BrowserWindow browserWindow = BrowserWindow.Launch(PageUrl);
            browserWindow.SetFocus();
            SilverlightButton button = browserWindow.Find<SilverlightButton>(By.AutomationId("displayChildWindowButton"));
            button.Click();

            SilverlightChildWindow childWindow = browserWindow.Find<SilverlightChildWindow>(By.AutomationId("TestChildWindow"));
            SilverlightButton okButton = childWindow.Find<SilverlightButton>(By.AutomationId("OKButton"));
            okButton.Click();

            browserWindow.Close();
        }
    }
}

