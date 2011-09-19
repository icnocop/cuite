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
        [TestMethod]
        public void SampleTestNumber1()
        {
            CUITe_BrowserWindow.CloseAllBrowsers();
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
            string s = "";
            foreach (string x in ht.Keys)
            {
                s += x + ": " + ht[x].ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        [TestMethod]
        public void Telerik_Combo()
        {
            CUITe_BrowserWindow.CloseAllBrowsers();
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
            CUITe_BrowserWindow bWin = new CUITe_BrowserWindow("Gmail: Email from Google");
            bWin.GetHtmlEdit("Id=Email").SetText("xyz@gmail.com");
            bWin.GetHtmlPassword("Id=Password").SetText("MyPa$$Word");
            bWin.GetHtmlInputButton("Id=signIn").Click();
        }
    }
}
