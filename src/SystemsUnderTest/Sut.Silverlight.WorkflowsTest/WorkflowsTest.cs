using System.IO;
using CassiniDev;
using CUITe.PageObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Silverlight.WorkflowsTest.PageObjects;
using Sut.Silverlight.WorkflowsTest.Workflows;

namespace Sut.Silverlight.WorkflowsTest
{
    /// <summary>
    /// Workflows test
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.Silverlight.Workflows.html")]
    [DeploymentItem("Sut.Silverlight.Workflows.xap")]
    public class WorkflowsTest
    {
        private static readonly CassiniDevServer WebServer = new CassiniDevServer();

        private NamePage namePage;

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
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            namePage = Page.Launch<NamePage>(WebServer.RootUrl + "Sut.Silverlight.Workflows.html");
        }

        /// <summary>
        /// Steps the through wizard.
        /// </summary>
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