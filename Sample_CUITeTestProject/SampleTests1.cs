using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Collections;
using CUITe;
using CUITe.Controls;
using CUITe.Controls.HtmlControls;
using Sample_CUITeTestProject.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Threading;

namespace Sample_CUITeTestProject
{
    [CodedUITest]
    public class SampleTests1
    {
        [TestInitialize]
        public void TestInitialize()
        {
            CUITe_BrowserWindow.CloseAllBrowsers();
        }

        [TestMethod]
        public void SampleTestNumber1()
        {
            CUITe_BrowserWindow.Launch("http://www.google.com");
            GoogleHomePage pgGHomePage = CUITe_BrowserWindow.GetBrowserWindow<GoogleHomePage>();
            pgGHomePage.txtSearch.SetText("Coded UI Test Framework");
            pgGHomePage.btnGoogleSearch.Click();
            GoogleSearch pgSearch = CUITe_BrowserWindow.GetBrowserWindow<GoogleSearch>();

            UITestControlCollection col = pgSearch.divSearchResults.UnWrap().GetChildren();

            foreach (UITestControl bas in col)
            {
                if (bas.GetType() == typeof(HtmlDiv))
                {
                    HtmlDiv div = (HtmlDiv)bas;
                    if (div.GetProperty("class").ToString() == "s")
                    {
                        string sContent = div.InnerText;
                        MessageBox.Show(sContent);
                    }
                }
            }

            //ArrayList col = pgSearch.divSearchResults.GetChildren();

            //foreach (CUITe_ControlBase bas in col)
            //{
            //    if (bas.GetType() == typeof(CUITe_HtmlDiv)) 
            //    {
            //        CUITe_HtmlDiv div = (CUITe_HtmlDiv)bas;
            //        if (div.UnWrap().GetProperty("class").ToString() == "s")
            //        {
            //            string sContent = div.InnerText;
            //            MessageBox.Show(sContent);
            //        }
            //    }
            //}
        }

        [TestMethod]
        public void TestMethod1()
        {
            Hashtable ht = CUITe_DataManager.GetDataRow(Type.GetType("Sample_CUITeTestProject.SampleTests1"), "XMLFile1.xml", "tc2");
            Assert.AreEqual("test", ht["test"]);
            Assert.AreEqual("Kondapur, Hyderabad", ht["address"]);
            Assert.AreEqual("Suresh", ht["firstname"]);
            Assert.AreEqual("Balasubramanian", ht["lastname"]);
            Assert.AreEqual("04/19/1973", ht["dob"]);
            Assert.AreEqual("37", ht["age"]);
            Assert.AreEqual("Indian", ht["nationality"]);
        }

        [TestMethod]
        public void Telerik_Combo()
        {
            CUITe_BrowserWindow.Launch("http://demos.telerik.com/aspnet-ajax/combobox/examples/default/defaultcs.aspx");
            ASPNETComboBoxDemoFirstLook pgPage = CUITe_BrowserWindow.GetBrowserWindow<ASPNETComboBoxDemoFirstLook>();
            Thread.Sleep(5000);
            pgPage.Refresh();
            Thread.Sleep(5000);
            pgPage.combo1.SelectItemByText("Tofu", 5000);
            pgPage.combo2.SelectItemByText("Bloomfield Hills", 5000);
            pgPage.combo3.SelectItemByText("Exotic Liquids", 5000);
            pgPage.combo4.SelectItemByText("American Express", 5000);
        }

        [TestMethod]
        public void Test_FeatureRequest_608()
        {
            CUITe_BrowserWindow.Launch("http://mail.google.com");
            CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("Gmail: Email from Google");
            bWin.Get<CUITe_HtmlEdit>("Id=Email").SetText("xyz@gmail.com");
            bWin.Get<CUITe_HtmlPassword>("Id=Password").SetText("MyPa$$Word");
            bWin.Get<CUITe_HtmlInputButton>("Id=signIn").Click();
        }

        [TestMethod]
        [ExpectedException(typeof(CUITe_InvalidSearchKey))]
        public void Test_FeatureRequest_588()
        {
            CUITe_BrowserWindow.Launch("http://www.google.com");
            Google pgGHome = CUITe_BrowserWindow.GetBrowserWindow<Google>();
            pgGHome.div588.Click();
        }

        [TestMethod]
        public void Test_FeatureRequest_589()
        {
            CUITe_BrowserWindow.Launch("http://www.google.com");
            GoogleHomePage pgGHomePage = CUITe_BrowserWindow.GetBrowserWindow<GoogleHomePage>();
            
            HtmlEdit tmp = new HtmlEdit(pgGHomePage);
            tmp.SearchProperties.Add("Id", "lst-ib");

            CUITe_HtmlEdit txtEdit = new CUITe_HtmlEdit();
            txtEdit.WrapReady(tmp);
            txtEdit.SetText("Coded UI Test enhanced Framework");
        }
    }
}
