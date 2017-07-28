using CUITe.Controls.WpfControls;
using CUITe.ScreenObjects;
using CUITe.SearchConfigurations;

namespace Sut.Wpf.WorkflowsTest.ScreenObjects
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
            set { Find<WpfEdit>(By.AutomationId("mdNHebXTWk-wyMAT-s9E9w")).Text = value; }
        }

        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            set { Find<WpfEdit>(By.AutomationId("-AznSNfwFECcKnlU7ZP-_A")).Text = value; }
        }

        /// <summary>
        /// Sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode
        {
            set { Find<WpfEdit>(By.AutomationId("RjTuE6e3I06Q5mcPIS4uZw")).Text = value; }
        }

        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            set { Find<WpfEdit>(By.AutomationId("F5PsSJJtB0SqhBZdswzhaQ")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The Finished Wizard Page</returns>
        public FinishedWizardPage ClickNext()
        {
            Find<WpfButton>(By.AutomationId("UXusDRFCMUu3uZqhbDDf0g")).Click();
            return GetScreenObject<FinishedWizardPage>();
        }
    }
}