using CUITe.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sut.Wpf.WorkflowsTest.ObjectRepository;
using Sut.Wpf.WorkflowsTest.Workflows;

namespace Sut.Wpf.WorkflowsTest
{
    [CodedUITest]
    public class WorkflowsTest
    {
#if DEBUG
        private const string ApplicationFilePath = @"..\..\..\Sut.Wpf.Workflows\bin\Debug\Sut.Wpf.Workflows.exe";
#else
        private const string ApplicationFilePath = @"..\..\..\Sut.Wpf.Workflows\bin\Release\Sut.Wpf.Workflows.exe";
#endif
        private MainScreen mainScreen;

        /// <summary>
        /// Gets or sets the test context which provides information about and functionality for
        /// the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            mainScreen = Screen.Launch<MainScreen>(ApplicationFilePath);
        }

        [TestMethod]
        public void StepThroughWizard()
        {
            // Arrange
            var workflow = new WizardWorkflow(mainScreen.NamePage);

            // Act
            FinishedScreenComponent finishedPage = workflow.StepThrough();

            // Assert
            Assert.IsTrue(finishedPage.CongratulationsExists);
        }
    }
}