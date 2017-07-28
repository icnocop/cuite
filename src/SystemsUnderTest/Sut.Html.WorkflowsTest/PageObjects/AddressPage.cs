using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.WorkflowsTest.PageObjects
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
            set { Find<HtmlEdit>(By.Id("address")).Text = value; }
        }

        /// <summary>
        /// Sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            set { Find<HtmlEdit>(By.Id("city")).Text = value; }
        }

        /// <summary>
        /// Sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode
        {
            set { Find<HtmlEdit>(By.Id("postalcode")).Text = value; }
        }

        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            set { Find<HtmlEdit>(By.Id("state")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The finished page.</returns>
        public FinishedPage ClickNext()
        {
            Find<HtmlButton>(By.Id("next")).Click();
            return GetPageObject<FinishedPage>();
        }
    }
}