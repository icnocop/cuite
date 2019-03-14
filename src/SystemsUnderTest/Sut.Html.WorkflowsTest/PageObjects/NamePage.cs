using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.WorkflowsTest.PageObjects
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
            set { Find<HtmlEdit>(By.Id("firstname")).Text = value; }
        }

        /// <summary>
        /// Sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname
        {
            set { Find<HtmlEdit>(By.Id("surname")).Text = value; }
        }

        /// <summary>
        /// Clicks the next button.
        /// </summary>
        /// <returns>The address page.</returns>
        public AddressPage ClickNext()
        {
            Find<HtmlButton>(By.Id("next")).Click();
            return GetPageObject<AddressPage>();
        }
    }
}