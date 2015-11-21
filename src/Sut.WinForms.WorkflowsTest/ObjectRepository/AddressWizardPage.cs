using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ObjectRepository
{
    public class AddressWizardPage : Screen
    {
        public string Address
        {
            set { Find<WinEdit>(By.ControlName("textBoxAddress").AndName("Address")).Text = value; }
        }

        public string City
        {
            set { Find<WinEdit>(By.ControlName("textBoxCity").AndName("City")).Text = value; }
        }

        public string PostalCode
        {
            set { Find<WinEdit>(By.ControlName("textBoxPostalCode").AndName("PostalCode")).Text = value; }
        }

        public string State
        {
            set { Find<WinEdit>(By.ControlName("textBoxState").AndName("State")).Text = value; }
        }

        public FinishedWizardPage ClickNext()
        {
            Find<WinButton>(By.Name("Next")).Click();
            return GetComponent<FinishedWizardPage>();
        }
    }
}