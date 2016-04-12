using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.WorkflowsTest.PageObjects
{
    public class AddressPage : Page
    {
        public string Address
        {
            set { Find<HtmlEdit>(By.Id("address")).Text = value; }
        }

        public string City
        {
            set { Find<HtmlEdit>(By.Id("city")).Text = value; }
        }

        public string PostalCode
        {
            set { Find<HtmlEdit>(By.Id("postalcode")).Text = value; }
        }

        public string State
        {
            set { Find<HtmlEdit>(By.Id("state")).Text = value; }
        }

        public FinishedPage ClickNext()
        {
            Find<HtmlButton>(By.Id("next")).Click();
            return GetPageObject<FinishedPage>();
        }
    }
}