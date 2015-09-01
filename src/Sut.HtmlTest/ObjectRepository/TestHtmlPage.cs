using CUITe.Controls.HtmlControls;

namespace Sut.HtmlTest.ObjectRepository
{
    public class TestHtmlPage : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "A Test";

        public HtmlParagraph p
        {
            get { return Find<HtmlParagraph>("id=para1"); }
        }

        public HtmlUnorderedList list
        {
            get { return Find<HtmlUnorderedList>("id=unorderedList"); }
        }
    }
}