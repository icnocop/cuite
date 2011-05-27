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
    }
}
