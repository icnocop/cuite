using System;
using System.IO;
using CassiniDev;
using CUITe.Controls;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.SilverlightTest.ObjectRepository;

namespace Sut.SilverlightTest
{
    [CodedUITest]
    [DeploymentItem("Sut.Silverlight.html")]
#if DEBUG
    [DeploymentItem(@"..\..\..\Sut.Silverlight\Bin\Debug\Sut.Silverlight.xap")]
#else
    [DeploymentItem(@"..\..\..\Sut.Silverlight\Bin\Release\Sut.Silverlight.xap")]
#endif
    public class SilverlightControlTests
    {
        //TODO: the silverlight control must be hosted on a page served through a web server (ex. iis, cassini \ web dev server) because IE 9 may
        //treat web pages differently between http://localhost and file:// (compatibility mode\view)

        private static readonly string CurrentDirectory = Directory.GetCurrentDirectory();
        private static readonly CassiniDevServer WebServer = new CassiniDevServer();
        private readonly string silverlightApplicationHtmlPageUrl = string.Format("http://{0}:{1}/Sut.Silverlight.html", HostName, Port);
        private const string HostName = "localhost";
        private const int Port = 8080;
        
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
            BrowserWindowUnderTest b = BrowserWindowUnderTest.Launch(silverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            b.Find<SilverlightButton>(By.SearchProperties("AutomationId=button1")).Click();
            SilverlightEdit oEdit = b.Find<SilverlightEdit>(By.SearchProperties("AutomationId=textBox1"));
            oEdit.SetText("asddasdasdasdadasdadasdadadadasd");
            SilverlightDatePicker dp = b.Find<SilverlightDatePicker>(By.SearchProperties("AutomationId=datePicker1"));
            dp.SourceControl.SelectedDate = new DateTime(2011, 5, 11);
            b.Close();
        }

        [TestMethod]
        public void SlList_InObjectRepository_Succeeds()
        {
            SlTestPage oSlTestPage = BrowserWindowUnderTest.Launch<SlTestPage>(silverlightApplicationHtmlPageUrl);
            oSlTestPage.oList.SelectedIndices = new[] { 2 };
            Assert.IsTrue(oSlTestPage.oList.SelectedItemsAsString == "Coded UI Test");
            oSlTestPage.Close();
        }

        [TestMethod]
        public void SlList_DynamicObjectRecognition_Succeeds()
        {
            BrowserWindowUnderTest b = BrowserWindowUnderTest.Launch(silverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            SilverlightList oList = b.Find<SilverlightList>(By.SearchProperties("AutomationId=listBox1"));
            oList.SelectedIndices = new[] { 2 };
            Assert.IsTrue(oList.SelectedItemsAsString == "Coded UI Test");
            b.Close();
        }

        [TestMethod]
        public void SlComboBox_SelectItem_Succeeds()
        {
            BrowserWindowUnderTest.Launch(silverlightApplicationHtmlPageUrl);
            BrowserWindowUnderTest b = new BrowserWindowUnderTest("Home");
            b.SetFocus();
            SilverlightComboBox oCombo = b.Find<SilverlightComboBox>(By.SearchProperties("AutomationId=comboBox1"));
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
            BrowserWindowUnderTest b = BrowserWindowUnderTest.Launch(silverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            SilverlightTab oTab = b.Find<SilverlightTab>(By.SearchProperties("AutomationId=tabControl1"));
            oTab.SelectedIndex= 1;
            Assert.IsTrue(oTab.SourceControl.Items[0].Name == "tabItem1");
            b.Close();
        }

        [TestMethod]
        public void SlTab_TraverseSiblingsAndChildren_Succeeds()
        {
            BrowserWindowUnderTest b = BrowserWindowUnderTest.Launch(silverlightApplicationHtmlPageUrl, "Home");
            b.SetFocus();
            SilverlightTab oTab = b.Find<SilverlightTab>(By.SearchProperties("AutomationId=tabControl1"));
            oTab.SelectedIndex = 0;
            var btnOK = b.Find<SilverlightButton>(By.SearchProperties("AutomationId=OKButtonInTabItem1"));
            ((SilverlightEdit)(btnOK.PreviousSibling)).SetText("blah blah hurray");
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
    }
}

