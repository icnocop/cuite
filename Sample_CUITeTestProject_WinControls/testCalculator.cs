using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Sample_CUITeTestProject_WinControls.ObjectLibrary;

namespace Sample_CUITeTestProject_WinControls
{
    /// <summary>
    /// Summary description for TestCalculator
    /// </summary>
    [CodedUITest]
    public class testCalculator
    {
        public testCalculator() { }

        private static string testProcess = "calc";
        private ApplicationUnderTest testApp;
        private winCalculator mainWindow = new winCalculator();

        [TestMethod, Description("Switch to Scientific view")]
        public void TestSwitchToScientific()
        {
            mainWindow.SetFocus();

            // Pick the Scientific menu
            mainWindow.miView.Click();
            mainWindow.miScientific.Click();

            // Make menu is checked and Degrees radio button is now present
            Assert.IsTrue(mainWindow.miScientific.Checked);
            Assert.IsTrue(mainWindow.rbDegrees.Exists);
        }

        [TestMethod, Description("Add two numbers")]
        public void TestCalculate()
        {
            mainWindow.SetFocus();

            mainWindow.btnClear.Click(); // Clear
            mainWindow.btn1.Click(); // Click 1
            mainWindow.btnAdd.Click(); // Click +
            mainWindow.btn2.Click(); // Click 2
            mainWindow.btnEquals.Click(); // Click =

            Assert.AreEqual("3", mainWindow.txtResult.DisplayText);
        }


        #region Additional test attributes

        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext) { }

        [ClassCleanup]
        public static void MyClassCleanup()
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
        public void MyTestInitialize()
        {
            // Launch Calculator if not already running
            if (Process.GetProcessesByName(testProcess).Length == 0)
            {
                testApp = ApplicationUnderTest.Launch(@"C:\Windows\system32\" + testProcess + ".exe");
            }

            // Make sure the view is Standard
            winCalculator mainWindow = new winCalculator();
            if (!mainWindow.miStandard.Checked)
            {
                mainWindow.miView.Click();
                mainWindow.miStandard.Click();
            }
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            // If test failed, then close the app. The next test will restart
            if (testContextInstance.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                testApp.Close();
            }
        }

        #endregion

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
        private TestContext testContextInstance;
    }
}
