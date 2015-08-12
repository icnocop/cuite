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
                return this.Get<HtmlParagraph>("id=para1");
            }
        }

        public HtmlUnorderedList list
        {
            get
            {
                return this.Get<HtmlUnorderedList>("id=unorderedList");
            }
        }
    }
}
