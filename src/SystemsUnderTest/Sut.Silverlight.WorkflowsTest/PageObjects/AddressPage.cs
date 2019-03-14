using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.WorkflowsTest.PageObjects
{
    /// <summary>
    /// Address Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class AddressPage : Page
    {
        /// <summary>
        /// Sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            set { Find<SilverlightEdit>(By.AutomationId("qIbEFMPVDkKVav6IoeW6lw")).Text = value; }
        }

        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            set { Find<SilverlightEdit>(By.AutomationId("jpZqSIgz6E-OZYvjRENYqA")).Text = value; }
        }

        /// <summary>
        /// Sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode
        {
            set { Find<SilverlightEdit>(By.AutomationId("88A1x0OcjEKBUFdSkGyHbg")).Text = value; }
        }

        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            set { Find<SilverlightEdit>(By.AutomationId("MjZSFASTiUC-DXKvXnFVyA")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The finished page</returns>
        public FinishedPage ClickNext()
        {
            Find<SilverlightButton>(By.AutomationId("bjkpOK_yG0eXEweEXWbeTg")).Click();
            return GetPageObject<FinishedPage>();
        }
    }
}