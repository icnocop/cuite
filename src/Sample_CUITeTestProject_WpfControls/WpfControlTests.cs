using System;
using System.Diagnostics;
using System.IO;
using CUITe.Controls.WpfControls;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample_CUITeTestProject_WpfControls.ObjectLibrary;

namespace Sample_CUITeTestProject_WpfControls
{
    /// <summary>
    /// Summary description for WpfControlTests
    /// </summary>
    [CodedUITest]
#if DEBUG
    [DeploymentItem(@"..\..\..\ControlTemplateExamples\bin\Debug")]
#else
    [DeploymentItem(@"..\..\..\ControlTemplateExamples\bin\Release")]
#endif
    public class WpfControlTests
    {
        private TestContext testContextInstance;
        private static string testProcess = "ControlTemplateExamples";
        private ApplicationUnderTest testApp;
        private WinWpfControls mainWindow = new WinWpfControls();

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

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // Close the app after all tests are finished
            Playback.Initialize();
            try
            {
                Process[] processes = Process.GetProcessesByName(testProcess);

                foreach (Process process in processes)
                {
                    ApplicationUnderTest app = ApplicationUnderTest.FromProcess(process);
                    app.Close();
                }
            }
            finally
            {
                Playback.Cleanup();
            }
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            if (Process.GetProcessesByName(testProcess).Length == 0)
            {
                testApp = ApplicationUnderTest.Launch(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, testProcess + ".exe"));
            }
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            if (testContextInstance.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                testApp.Close();
            }
        }

        [TestMethod]
        public void WpfButton_Click_Succeeds()
        {
            mainWindow.SetFocus();
            mainWindow.btnDefault.Click();
            Assert.AreEqual("Default", mainWindow.btnDefault.DisplayText);
        }

        [TestMethod]
        public void WpfCheckBox_Checked_Succeeds()
        {
            mainWindow.SetFocus();
            Assert.AreEqual(false, mainWindow.chkNormal.Checked);
            Assert.AreEqual(true, mainWindow.chkChecked.Checked);
            Assert.AreEqual(true, mainWindow.chkIndeterminate.Indeterminate);
        }

        [TestMethod]
        public void WpfTable_GetRowAndCellByAutomationId_CanGetCellValue()
        {
            CUITe_WpfRow row0 = mainWindow.dg1.Get<CUITe_WpfRow>("AutomationId=Row0");
            CUITe_WpfCell row0cell0 = row0.Get<CUITe_WpfCell>("AutomationId=cellRow0Col0");
            Assert.AreEqual("XML in Action", row0cell0.Value);
        }

        [TestMethod]
        public void WpfListView_GetRow_CanClickOnRow()
        {
            CUITe_WpfTable listView = mainWindow.Get<CUITe_WpfTable>("AutomationId=lv1");
            Assert.AreEqual(8, listView.RowCount);
            CUITe_WpfControl<WpfControl> control = listView.Get<CUITe_WpfControl<WpfControl>>("AutomationId=Item0");
            control.Click();
        }

        [TestMethod]
        public void WpfListView_GetRow_CanClickOnCell()
        {
            CUITe_WpfTable listView = mainWindow.Get<CUITe_WpfTable>("AutomationId=lv1");
            Assert.AreEqual(8, listView.RowCount);
            CUITe_WpfControl<WpfControl> control = listView.Get<CUITe_WpfControl<WpfControl>>("AutomationId=Item0");
            CUITe_WpfCell cell = control.Get<CUITe_WpfCell>("ColumnHeader=Content");
            cell.Click();
        }
    }
}
