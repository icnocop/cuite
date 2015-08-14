using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
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
