using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.WorkflowsTest.PageObjects
{
    public class NamePage : Page
    {
        public string FirstName
        {
            set { Find<HtmlEdit>(By.Id("firstname")).Text = value; }
        }

        public string Surname
        {
            set { Find<HtmlEdit>(By.Id("surname")).Text = value; }
        }

        public AddressPage ClickNext()
        {
            Find<HtmlButton>(By.Id("next")).Click();
            return GetPageObject<AddressPage>();
        }
    }
}