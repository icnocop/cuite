using CUITe.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.WorkflowsTest.ScreenObjects;
using Sut.Wpf.WorkflowsTest.Workflows;

namespace Sut.Wpf.WorkflowsTest
{
    [CodedUITest]
#if DEBUG
    [DeploymentItem(@"..\..\..\Sut.Wpf.Workflows\bin\Debug\Sut.Wpf.Workflows.exe")]
#else
    [DeploymentItem(@"..\..\..\Sut.Wpf.Workflows\bin\Release\Sut.Wpf.Workflows.exe")]
#endif
    public class WorkflowsTest
    {
        private const string ApplicationFilePath = @"Sut.Wpf.Workflows.exe";
        private NameWizardPage nameWizardPage;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            nameWizardPage = Screen.Launch<NameWizardPage>(ApplicationFilePath);
        }

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