using CUITe.Workflows;
using Sut.Wpf.WorkflowsTest.ObjectRepository;

namespace Sut.Wpf.WorkflowsTest.Workflows
{
    public class WizardWorkflow : Workflow<NameScreenComponent, FinishedScreenComponent>
    {
        public WizardWorkflow(NameScreenComponent start)
            : base(start)
        {
        }

        public override FinishedScreenComponent StepThrough()
        {
            // Enter name
            Start.FirstName = "Some first name";
            Start.Surname = "Some surname";

            // Click next
            AddressScreenComponent addressPage = Start.ClickNext();

            // Enter address
            addressPage.Address = "Some address";
            addressPage.City = "Some city";
            addressPage.PostalCode = "Some postal code";
            addressPage.State = "Some state";
            
            // Click next
            return addressPage.ClickNext();
        }
    }
}