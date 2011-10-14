using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.IO;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;
using Sample_CUITeTestProject.ObjectRepository;

namespace Sample_CUITeTestProject
{
    [CodedUITest]
    [DeploymentItem(@"Sample_CUITeTestProject\TestSilverlightApplication.xap")]
    [DeploymentItem(@"Sample_CUITeTestProject\TestSilverlightApplication.html")]
    public class Tests_for_SilverlightControls
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void Test_SlButtonAndEditAndDTP()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).CodeBase);
            CUITe_BrowserWindow.Launch(baseDir + "/TestSilverlightApplication.html");
            CUITe_BrowserWindow b = new CUITe_BrowserWindow("Home");
            b.SetFocus();
            b.Get<CUITe_SlButton>("Name=button1").Click();
            CUITe_SlEdit oEdit = b.Get<CUITe_SlEdit>("Name=textBox1");
            oEdit.SetText("asddasdasdasdadasdadasdadadadasd");
            CUITe_SlDatePicker dp = b.Get<CUITe_SlDatePicker>("Name=datePicker1");
            dp.UnWrap().SelectedDateAsString = "5/11/11";
        }

        [TestMethod]
        public void Test_SlList()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).CodeBase);
            CUITe_BrowserWindow.Launch(baseDir + "/TestSilverlightApplication.html");
            CUITe_BrowserWindow b = new CUITe_BrowserWindow("Home");
            b.SetFocus();
            CUITe_SlList oList = b.Get<CUITe_SlList>("Name=listBox1");
            oList.SelectedIndices = new int[] { 2 };
            Assert.IsTrue(oList.SelectedItemsAsString == "Coded UI Test");
        }

        [TestMethod]
        public void Test_SlComboBox()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).CodeBase);
            CUITe_BrowserWindow.Launch(baseDir + "/TestSilverlightApplication.html");
            CUITe_BrowserWindow b = new CUITe_BrowserWindow("Home");
            b.SetFocus();
            CUITe_SlComboBox oCombo = b.Get<CUITe_SlComboBox>("Name=comboBox1");
            oCombo.SelectItem(3);
        }
    }
}

