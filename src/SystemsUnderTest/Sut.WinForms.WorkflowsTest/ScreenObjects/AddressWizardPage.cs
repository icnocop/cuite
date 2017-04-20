using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ScreenObjects
{
    public class AddressWizardPage : Screen
    {
        public string Address
        {
            set { Find<WinWindow>(By.ControlName("textBoxAddress")).Find<WinEdit>(By.Name("Address")).Text = value; }
        }

        public string City
        {
            set { Find<WinWindow>(By.ControlName("textBoxCity")).Find<WinEdit>(By.Name("City")).Text = value; }
        }

        public string PostalCode
        {
            set { Find<WinWindow>(By.ControlName("textBoxPostalCode")).Find<WinEdit>(By.Name("PostalCode")).Text = value; }
        }

        public string State
        {
            set { Find<WinWindow>(By.ControlName("textBoxState")).Find<WinEdit>(By.Name("State")).Text = value; }
        }

        public FinishedWizardPage ClickNext()
        {
            Find<WinWindow>(By.ControlName("buttonNext")).Find<WinButton>(By.Name("Next")).Click();
            return GetScreenObject<FinishedWizardPage>();
        }
    }
}