using CUITe.Workflows;
using Sut.Wpf.WorkflowsTest.ObjectRepository;

namespace Sut.Wpf.WorkflowsTest.Workflows
{
    public class WizardWorkflow : Workflow<NameWizardPage, FinishedWizardPage>
    {
        public WizardWorkflow(NameWizardPage start)
            : base(start)
        {
        }

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