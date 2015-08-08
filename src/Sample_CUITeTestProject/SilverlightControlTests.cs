using System;
using System.IO;
using CassiniDev;
using CUITe.Controls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample_CUITeTestProject.ObjectRepository;

namespace Sample_CUITeTestProject
{
    [CodedUITest]
    [DeploymentItem(@"Sample_CUITeTestProject\TestSilverlightApplication.xap")]
    [DeploymentItem(@"Sample_CUITeTestProject\TestSilverlightApplication.html")]
    public class SilverlightControlTests
    {
        //TODO: the silverlight control must be hosted on a page served through a web server (ex. iis, cassini \ web dev server) because IE 9 may
        //treat web pages differently between http://localhost and file:// (compatibility mode\view)

        private static string CurrentDirectory = Directory.GetCurrentDirectory();
        private const string HostName = "localhost";
        private const int Port = 8080;
        private string TestSilverlightApplicationHtmlPageUrl = string.Format("http://{0}:{1}/TestSilverlightApplication.html", HostName, Port);
        private static CassiniDevServer WebServer = new CassiniDevServer();

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            WebServer.StartServer(CurrentDirectory, Port, "/", HostName);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            WebServer.StopServer();
        }

        [TestMethod]
        public void SlButtonAndEditAndDTP_ClickAndSetTextAndSelectedDateAsString_Succeeds()
        {
            CUITe_BrowserWindow b = CUITe_BrowserWindow.Launch(TestSilverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            b.Get<CUITe_SlButton>("AutomationId=button1").Click();
            CUITe_SlEdit oEdit = b.Get<CUITe_SlEdit>("AutomationId=textBox1");
            oEdit.SetText("asddasdasdasdadasdadasdadadadasd");
            CUITe_SlDatePicker dp = b.Get<CUITe_SlDatePicker>("AutomationId=datePicker1");
            dp.UnWrap().SelectedDate = new DateTime(2011, 5, 11);
            b.Close();
        }

        [TestMethod]
        public void SlList_InObjectRepository_Succeeds()
        {
            SlTestPage oSlTestPage = CUITe_BrowserWindow.Launch<SlTestPage>(TestSilverlightApplicationHtmlPageUrl);
            oSlTestPage.oList.SelectedIndices = new int[] { 2 };
            Assert.IsTrue(oSlTestPage.oList.SelectedItemsAsString == "Coded UI Test");
            oSlTestPage.Close();
        }

        [TestMethod]
        public void SlList_DynamicObjectRecognition_Succeeds()
        {
            CUITe_BrowserWindow b = CUITe_BrowserWindow.Launch(TestSilverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            CUITe_SlList oList = b.Get<CUITe_SlList>("AutomationId=listBox1");
            oList.SelectedIndices = new int[] { 2 };
            Assert.IsTrue(oList.SelectedItemsAsString == "Coded UI Test");
            b.Close();
        }

        [TestMethod]
        public void SlComboBox_SelectItem_Succeeds()
        {
            CUITe_BrowserWindow.Launch(TestSilverlightApplicationHtmlPageUrl);
            CUITe_BrowserWindow b = new CUITe_BrowserWindow("Home");
            b.SetFocus();
            CUITe_SlComboBox oCombo = b.Get<CUITe_SlComboBox>("AutomationId=comboBox1");
            oCombo.SelectItem(3);
            foreach (string temp in oCombo.Items)
            {
                Console.WriteLine(temp);
            }
            b.Close();
        }

        [TestMethod]
        public void SlTab_SelectedIndex_Succeeds()
        {
            CUITe_BrowserWindow b = CUITe_BrowserWindow.Launch(TestSilverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            CUITe_SlTab oTab = b.Get<CUITe_SlTab>("AutomationId=tabControl1");
            oTab.SelectedIndex= 1;
            Assert.IsTrue(oTab.UnWrap().Items[0].Name == "tabItem1");
            b.Close();
        }

        [TestMethod]
        public void SlTab_TraverseSiblingsAndChildren_Succeeds()
        {
            CUITe_BrowserWindow b = CUITe_BrowserWindow.Launch(TestSilverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            CUITe_SlTab oTab = b.Get<CUITe_SlTab>("AutomationId=tabControl1");
            oTab.SelectedIndex = 0;
            var btnOK = b.Get<CUITe_SlButton>("AutomationId=OKButtonInTabItem1");
            var tmp = btnOK.PreviousSibling;
            ((CUITe_SlEdit)(btnOK.PreviousSibling)).SetText("blah blah hurray");
            foreach (ICUITe_ControlBase control in oTab.GetChildren())
            {
                if (control.GetType() == typeof(CUITe_SlEdit))
                {
                    ((CUITe_SlEdit)control).Text = "Text Changed";
                    break;
                }
            }
            Assert.IsTrue(((CUITe_SlTab)btnOK.Parent).SelectedItem == "tabItem1");
            b.Close();
        }
    }
}

