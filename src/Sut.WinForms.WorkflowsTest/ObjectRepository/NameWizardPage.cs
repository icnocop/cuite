using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ObjectRepository
{
    public class NameWizardPage : Screen
    {
        public string FirstName
        {
            set { Find<WinEdit>(By.ControlName("textBoxFirstName").AndName("FirstName")).Text = value; }
        }

        public string Surname
        {
            set { Find<WinEdit>(By.ControlName("textBoxSurname").AndName("Surname")).Text = value; }
        }

        public AddressWizardPage ClickNext()
        {
            Find<WinButton>(By.Name("Next")).Click();
            return GetComponent<AddressWizardPage>();
        }
    }
}