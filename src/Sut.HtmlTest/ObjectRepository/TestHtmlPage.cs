using CUITe.Controls.HtmlControls;

namespace Sut.HtmlTest.ObjectRepository
{
    public class TestHtmlPage : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "A Test";

        public HtmlParagraph p
        {
            get
            {
                return Get<HtmlParagraph>("id=para1");
            }
        }

        public HtmlUnorderedList list
        {
            get
            {
                return Get<HtmlUnorderedList>("id=unorderedList");
            }
        }
    }
}
