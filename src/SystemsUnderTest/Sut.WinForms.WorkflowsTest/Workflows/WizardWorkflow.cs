using CUITe.Workflows;
using Sut.WinForms.WorkflowsTest.ScreenObjects;

namespace Sut.WinForms.WorkflowsTest.Workflows
{
    /// <summary>
    /// Wizard Workflow
    /// </summary>
    /// <seealso cref="CUITe.Workflows.Workflow{NameWizardPage, FinishedWizardPage}" />
    public class WizardWorkflow : Workflow<NameWizardPage, FinishedWizardPage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardWorkflow"/> class.
        /// </summary>
        /// <param name="start">The view object where the workflow start.</param>
        public WizardWorkflow(NameWizardPage start)
            : base(start)
        {
        }

        /// <summary>
        /// Steps through the workflow.
        /// </summary>
        /// <returns>
        /// The view object where the workflow end.
        /// </returns>
        public override FinishedWizardPage StepThrough()
        {
            // Enter name
            Start.FirstName = "Some first name";
            Start.Surname = "Some surname";

            // Click next
            AddressWizardPage addressWizardPage = Start.ClickNext();

            // Enter address
            addressWizardPage.Address = "Some address";
            addressWizardPage.City = "Some city";
            addressWizardPage.PostalCode = "Some postal code";
            addressWizardPage.State = "Some state";

            // Click next
            return addressWizardPage.ClickNext();
        }
    }
}