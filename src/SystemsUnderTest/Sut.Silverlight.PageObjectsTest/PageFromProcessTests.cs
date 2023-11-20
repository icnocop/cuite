using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Automation;
using CassiniDev;
using CUITe.Controls;
using CUITe.PageObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHDocVw;
using Sut.Silverlight.PageObjectsTest.PageObjects;

namespace Sut.Silverlight.PageObjectsTest
{
    /// <summary>
    /// Page From Process Tests
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.Silverlight.PageObjects.html")]
    [DeploymentItem("Sut.Silverlight.PageObjects.xap")]
    public class PageFromProcessTests
    {
        private static readonly CassiniDevServer WebServer = new CassiniDevServer();
        private static readonly AutoResetEvent completed = new AutoResetEvent(false);
        private const int NavigationNoReadFromCache = 0x4;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            WebServer.StartServer(Directory.GetCurrentDirectory());

            // always wait until controls are ready
            ControlBase.IsControlReadinessAwaitedByDefault = true;
        }

        /// <summary>
        /// Cleans up the class.
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            WebServer.StopServer();
        }

        /// <summary>
        /// Asserts that a call to <see cref="Page.FromProcess{T}(Process)"/> succeeds.
        /// </summary>
        [TestMethod]
        public void FromProcess_WithPage_Succeeds()
        {
            InternetExplorer ie = (InternetExplorer)Activator.CreateInstance(Type.GetTypeFromProgID("InternetExplorer.Application"));

            ie.Visible = true;
            ie.DocumentComplete += OnDocumentComplete;

            ie.Navigate(WebServer.RootUrl + "Sut.Silverlight.PageObjects.html", NavigationNoReadFromCache);
            completed.WaitOne();

            long windowHandle = ie.HWND;
            IntPtr intPtr = new IntPtr(windowHandle);
            AutomationElement childWindowElement = AutomationElement.FromHandle(intPtr);
            childWindowElement.SetFocus();

            Process process = Process.GetProcessById(childWindowElement.Current.ProcessId);

            var mainPage = Page.FromProcess<MainPage>(process);
            Assert.IsTrue(mainPage.Self.Exists);
            Assert.IsTrue(mainPage.LowerLeft.RadioButtonExists);

            ie.Quit();
        }

        private static void OnDocumentComplete(object pDisp, ref object URL)
        {
            completed.Set();
        }
    }
}
