using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.WorkflowsTest.ScreenObjects
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
            set { Find<WpfEdit>(By.AutomationId("dKY2UyRoTEa_40c0jSEIuQ")).Text = value; }
        }

        /// <summary>
        /// Sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname
        {
            set { Find<WpfEdit>(By.AutomationId("JQT9WV1Be0CN0ps04dxnww")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The address wizard page.</returns>
        public AddressWizardPage ClickNext()
        {
            Find<WpfButton>(By.AutomationId("UXusDRFCMUu3uZqhbDDf0g")).Click();
            return GetScreenObject<AddressWizardPage>();
        }
    }
}