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
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

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

        [TestInitialize]
        public void TestInitialize()
        {
            //CUITe_BrowserWindow.CloseAllBrowsers();
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
            b.Close();
        }

        [TestMethod]
        public void Test_SlList_ViaObjectRepository()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).CodeBase);
            CUITe_BrowserWindow.Launch(baseDir + "/TestSilverlightApplication.html");
            SlTestPage oSlTestPage = CUITe_BrowserWindow.GetBrowserWindow<SlTestPage>();
            oSlTestPage.oList.SelectedIndices = new int[] { 2 };
            Assert.IsTrue(oSlTestPage.oList.SelectedItemsAsString == "Coded UI Test");
            oSlTestPage.Close();
        }

        [TestMethod]
        public void Test_SlList_DynamicObjectRecognition()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).CodeBase);
            CUITe_BrowserWindow.Launch(baseDir + "/TestSilverlightApplication.html");
            CUITe_BrowserWindow b = new CUITe_BrowserWindow("Home");
            b.SetFocus();
            CUITe_SlList oList = b.Get<CUITe_SlList>("Name=listBox1");
            oList.SelectedIndices = new int[] { 2 };
            Assert.IsTrue(oList.SelectedItemsAsString == "Coded UI Test");
            b.Close();
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
            foreach (string temp in oCombo.Items)
            {
                Console.WriteLine(temp);
            }
            b.Close();
        }

        [TestMethod]
        public void Test_SlTab()
        {
            string baseDir = Path.GetDirectoryName(Assembly.GetAssembly(this.GetType()).CodeBase);
            CUITe_BrowserWindow.Launch(baseDir + "/TestSilverlightApplication.html");
            CUITe_BrowserWindow b = new CUITe_BrowserWindow("Home");
            b.SetFocus();
            CUITe_SlTab oTab = b.Get<CUITe_SlTab>("Name=tabControl1");
            oTab.UnWrap().SelectedIndex= 1;
            System.Windows.Forms.MessageBox.Show(oTab.UnWrap().Items[0].Name);
            b.Close();
        }

    }
}

