using CUITe.Workflows;
using Sut.Html.WorkflowsTest.PageObjects;

namespace Sut.Html.WorkflowsTest.Workflows
{
    /// <summary>
    /// Wizard Workflow
    /// </summary>
    /// <seealso cref="CUITe.Workflows.Workflow{NamePage, FinishedPage}" />
    public class WizardWorkflow : Workflow<NamePage, FinishedPage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardWorkflow"/> class.
        /// </summary>
        /// <param name="start">The view object where the workflow start.</param>
        public WizardWorkflow(NamePage start)
            : base(start)
        {
        }

        /// <summary>
        /// Steps through the workflow.
        /// </summary>
        /// <returns>
        /// The view object where the workflow end.
        /// </returns>
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