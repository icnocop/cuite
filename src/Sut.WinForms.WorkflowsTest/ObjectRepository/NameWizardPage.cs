using CUITe.Controls.WinControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ObjectRepository
{
    public class NameWizardPage : Screen
    {
        public string FirstName
        {
            set { Find<WinEdit>(By.Name("textBoxFirstName")).Text = value; }
        }

        public string Surname
        {
            set { Find<WinEdit>(By.Name("textBoxSurname")).Text = value; }
        }

        public AddressWizardPage ClickNext()
        {
            Find<WinButton>(By.Name("buttonNext")).Click();
            return GetComponent<AddressWizardPage>();
        }
    }
}