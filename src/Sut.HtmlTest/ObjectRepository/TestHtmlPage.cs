using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class TestHtmlPage : Page
    {
        public HtmlParagraph Paragraph
        {
            get { return Find<HtmlParagraph>(By.Id("para1")); }
        }

        public HtmlUnorderedList List
        {
            get { return Find<HtmlUnorderedList>(By.Id("unorderedList")); }
        }

        public HtmlDocument Document
        {
            get { return Find<HtmlDocument>(); }
        }
    }
}