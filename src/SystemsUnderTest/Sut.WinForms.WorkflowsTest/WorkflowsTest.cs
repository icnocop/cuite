using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.WinForms.WorkflowsTest.ScreenObjects;
using Sut.WinForms.WorkflowsTest.Workflows;

namespace Sut.WinForms.WorkflowsTest
{
    /// <summary>
    /// Workflows Test
    /// </summary>
    [CodedUITest]
    [DeploymentItem("Sut.WinForms.Workflows.exe")]
    public class WorkflowsTest
    {
        private const string ApplicationFilePath = "Sut.WinForms.Workflows.exe";
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
        /// Steps through the wizard.
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