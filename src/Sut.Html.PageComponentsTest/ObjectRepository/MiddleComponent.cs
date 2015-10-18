using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.ObjectRepository
{
    public class MiddleComponent : PageComponent
    {
        public AboutPage NavigateToAboutPage()
        {
            Find<HtmlButton>(By.Id("navigatetoabout")).Click();
            return NavigateTo<AboutPage>();
        }
    }
}