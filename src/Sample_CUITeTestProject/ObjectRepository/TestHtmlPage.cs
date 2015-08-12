using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class TestHtmlPage : CUITe_BrowserWindow
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
