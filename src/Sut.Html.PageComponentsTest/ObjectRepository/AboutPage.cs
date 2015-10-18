using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.Html.PageComponentsTest.ObjectRepository
{
    public class AboutPage : Page
    {
        public bool FrameworkMessageExists
        {
            get { return Find<HtmlParagraph>(By.Id("framework")).Exists; }
        }
    }
}