using CUITe.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.WinForms.WorkflowsTest.ObjectRepository;
using Sut.WinForms.WorkflowsTest.Workflows;

namespace Sut.WinForms.WorkflowsTest
{
    [CodedUITest]
    public class WorkflowsTest
    {
#if DEBUG
        private const string ApplicationFilePath = @"..\..\..\Sut.WinForms.Workflows\bin\Debug\Sut.WinForms.Workflows.exe";
#else
        private const string ApplicationFilePath = @"..\..\..\Sut.WinForms.Workflows\bin\Release\Sut.WinForms.Workflows.exe";
#endif
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