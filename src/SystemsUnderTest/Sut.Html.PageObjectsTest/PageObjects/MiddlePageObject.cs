using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    /// <summary>
    /// Middle Page Object
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.PageObject" />
    public class MiddlePageObject : PageObject
    {
        /// <summary>
        /// Navigates to about page.
        /// </summary>
        /// <returns></returns>
        public AboutPage NavigateToAboutPage()
        {
            Find<HtmlButton>(By.Id("navigatetoabout")).Click();
            return NavigateTo<AboutPage>();
        }
    }
}