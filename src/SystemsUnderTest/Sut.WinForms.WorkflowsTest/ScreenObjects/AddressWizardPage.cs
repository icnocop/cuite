using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ScreenObjects
{
    /// <summary>
    /// Address Wizard Page
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class AddressWizardPage : Screen
    {
        /// <summary>
        /// Sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            set { Find<WinWindow>(By.ControlName("textBoxAddress")).Find<WinEdit>(By.Name("Address")).Text = value; }
        }

        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            set { Find<WinWindow>(By.ControlName("textBoxCity")).Find<WinEdit>(By.Name("City")).Text = value; }
        }

        /// <summary>
        /// Sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode
        {
            set { Find<WinWindow>(By.ControlName("textBoxPostalCode")).Find<WinEdit>(By.Name("PostalCode")).Text = value; }
        }

        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            set { Find<WinWindow>(By.ControlName("textBoxState")).Find<WinEdit>(By.Name("State")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The Finish Wizard Page</returns>
        public FinishedWizardPage ClickNext()
        {
            Find<WinWindow>(By.ControlName("buttonNext")).Find<WinButton>(By.Name("Next")).Click();
            return GetScreenObject<FinishedWizardPage>();
        }
    }
}