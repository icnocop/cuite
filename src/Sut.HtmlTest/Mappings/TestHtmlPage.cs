using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.HtmlTest.Mappings
{
    public class TestHtmlPage : Page
    {
        public TestHtmlPage(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

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