using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class TestHtmlPage : BrowserWindowUnderTest
    {
        public HtmlParagraph p
        {
            get { return Find<HtmlParagraph>(By.Id("para1")); }
        }

        public HtmlUnorderedList list
        {
            get { return Find<HtmlUnorderedList>(By.Id("unorderedList")); }
        }
    }
}