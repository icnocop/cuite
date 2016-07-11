using System.IO;
using CassiniDev;
using CUITe.PageObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Silverlight.WorkflowsTest.PageObjects;
using Sut.Silverlight.WorkflowsTest.Workflows;

namespace Sut.Silverlight.WorkflowsTest
{
    [CodedUITest]
    [DeploymentItem("Sut.Silverlight.Workflows.html")]
#if DEBUG
    [DeploymentItem(@"..\..\..\Sut.Silverlight.Workflows\Bin\Debug\Sut.Silverlight.Workflows.xap")]
#else
    [DeploymentItem(@"..\..\..\Sut.Silverlight.Workflows\Bin\Release\Sut.Silverlight.Workflows.xap")]
#endif
    public class WorkflowsTest
    {
        private static readonly CassiniDevServer WebServer = new CassiniDevServer();

        private NamePage namePage;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            WebServer.StartServer(Directory.GetCurrentDirectory());
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            WebServer.StopServer();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            namePage = Page.Launch<NamePage>(WebServer.RootUrl + "Sut.Silverlight.Workflows.html");
        }

        [TestMethod]
        public void StepThroughWizard()
        {
            // Arrange
            var workflow = new WizardWorkflow(namePage);

            // Act
            FinishedPage finishedPage = workflow.StepThrough();

            // Assert
            Assert.IsTrue(finishedPage.CongratulationsExists);
        }
    }
}