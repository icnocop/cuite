using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageObjectsTest.PageObjects
{
    public class AboutPage : Page
    {
        public bool FrameworkMessageExists
        {
            get { return Find<HtmlParagraph>(By.Id("framework")).Exists; }
        }
    }
}