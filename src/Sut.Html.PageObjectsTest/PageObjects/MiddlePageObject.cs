using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class MiddlePageObject : PageObject
    {
        public AboutPage NavigateToAboutPage()
        {
            Find<HtmlButton>(By.Id("navigatetoabout")).Click();
            return NavigateTo<AboutPage>();
        }
    }
}