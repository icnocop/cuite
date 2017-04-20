using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ScreenObjects
{
    public class NameWizardPage : Screen
    {
        public string FirstName
        {
            set { Find<WinWindow>(By.ControlName("textBoxFirstName")).Find<WinEdit>(By.Name("FirstName")).Text = value; }
        }

        public string Surname
        {
            set { Find<WinWindow>(By.ControlName("textBoxSurname")).Find<WinEdit>(By.Name("Surname")).Text = value; }
        }

        public AddressWizardPage ClickNext()
        {
            Find<WinWindow>(By.ControlName("buttonNext")).Find<WinButton>(By.Name("Next")).Click();
            return GetScreenObject<AddressWizardPage>();
        }
    }
}