using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ObjectRepository
{
    public class AddressWizardPage : Screen
    {
        public string Address
        {
            set { Find<WinEdit>(By.Name("textBoxAddress")).Text = value; }
        }

        public string City
        {
            set { Find<WinEdit>(By.Name("textBoxCity")).Text = value; }
        }

        public string PostalCode
        {
            set { Find<WinEdit>(By.Name("textBoxPostalCode")).Text = value; }
        }

        public string State
        {
            set { Find<WinEdit>(By.Name("textBoxState")).Text = value; }
        }

        public FinishedWizardPage ClickNext()
        {
            Find<WinButton>(By.Name("buttonNext")).Click();
            return GetComponent<FinishedWizardPage>();
        }
    }
}