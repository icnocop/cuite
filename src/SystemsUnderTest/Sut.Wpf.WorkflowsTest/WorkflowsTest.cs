using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.WorkflowsTest.ScreenObjects;
using Sut.Wpf.WorkflowsTest.Workflows;

namespace Sut.Wpf.WorkflowsTest
{
    /// <summary>
    /// Workflow test
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.Wpf.Workflows.exe")]
    public class WorkflowsTest
    {
        private const string ApplicationFilePath = "Sut.Wpf.Workflows.exe";
        private NameWizardPage nameWizardPage;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            nameWizardPage = Screen.Launch<NameWizardPage>(ApplicationFilePath);
        }

        /// <summary>
        /// Steps the through wizard.
        /// </summary>
        [TestMethod]
        public void StepThroughWizard()
        {
            // Arrange
            var workflow = new WizardWorkflow(nameWizardPage);

            // Act
            FinishedWizardPage finishedWizardPage = workflow.StepThrough();

            // Assert
            Assert.IsTrue(finishedWizardPage.CongratulationsExists);
        }
    }
}