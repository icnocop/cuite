using CUITe.Controls.SilverlightControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Silverlight.WorkflowsTest.PageObjects
{
    /// <summary>
    /// Name Page
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class NamePage : Page
    {
        /// <summary>
        /// Sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            set { Find<SilverlightEdit>(By.AutomationId("F4M4dWKkHUim_c0InT860A")).Text = value; }
        }

        /// <summary>
        /// Sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname
        {
            set { Find<SilverlightEdit>(By.AutomationId("SF416_2UjEamJfUrETTf_g")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The address page</returns>
        public AddressPage ClickNext()
        {
            Find<SilverlightButton>(By.AutomationId("bjkpOK_yG0eXEweEXWbeTg")).Click();
            return GetPageObject<AddressPage>();
        }
    }
}