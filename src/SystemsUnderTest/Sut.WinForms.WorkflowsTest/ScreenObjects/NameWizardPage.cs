using CUITe.Controls.WinControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.WinForms.WorkflowsTest.ScreenObjects
{
    /// <summary>
    /// Name Wizard Page
    /// </summary>
    /// <seealso cref="CUITe.ScreenObjects.Screen" />
    public class NameWizardPage : Screen
    {
        /// <summary>
        /// Sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            set { Find<WinWindow>(By.ControlName("textBoxFirstName")).Find<WinEdit>(By.Name("FirstName")).Text = value; }
        }

        /// <summary>
        /// Sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname
        {
            set { Find<WinWindow>(By.ControlName("textBoxSurname")).Find<WinEdit>(By.Name("Surname")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The address wizard page.</returns>
        public AddressWizardPage ClickNext()
        {
            Find<WinWindow>(By.ControlName("buttonNext")).Find<WinButton>(By.Name("Next")).Click();
            return GetScreenObject<AddressWizardPage>();
        }
    }
}