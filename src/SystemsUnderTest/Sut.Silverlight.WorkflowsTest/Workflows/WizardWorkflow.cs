using CUITe.Workflows;
using Sut.Silverlight.WorkflowsTest.PageObjects;

namespace Sut.Silverlight.WorkflowsTest.Workflows
{
    public class WizardWorkflow : Workflow<NamePage, FinishedPage>
    {
        public WizardWorkflow(NamePage start)
            : base(start)
        {
        }

        public override FinishedPage StepThrough()
        {
            // Enter name
            Start.FirstName = "Some first name";
            Start.Surname = "Some surname";

            // Click next
            AddressPage addressPage = Start.ClickNext();

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