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
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Sample_CUITeTestProject_WpfControls.ObjectLibrary;

namespace Sample_CUITeTestProject_WpfControls
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    #if DEBUG
    [DeploymentItem(@"..\..\..\ControlTemplateExamples\bin\Debug")]
    #else
    [DeploymentItem(@"..\..\..\ControlTemplateExamples\bin\Release")]
    #endif
    public class testWpfControls
    {
        public testWpfControls() { }

        private static string testProcess = "ControlTemplateExamples";
        private ApplicationUnderTest testApp;
        private winWpfControls mainWindow = new winWpfControls();

        [TestMethod]
        public void testClickButton()
        {
            mainWindow.SetFocus();
            mainWindow.btnDefault.Click();
            Assert.AreEqual("Default", mainWindow.btnDefault.DisplayText);
        }

        [TestMethod]
        public void testCheckBox()
        {
            mainWindow.SetFocus();
            Assert.AreEqual(false, mainWindow.chkNormal.Checked);
            Assert.AreEqual(true, mainWindow.chkChecked.Checked);
            Assert.AreEqual(true, mainWindow.chkIndeterminate.Indeterminate);
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
            if (Process.GetProcessesByName(testProcess).Length == 0)
            {
                testApp = ApplicationUnderTest.Launch(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, testProcess + ".exe"));
            }
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
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
