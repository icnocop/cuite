using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class GoogleSearch : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "coded ui test framework - Google Search";
        public HtmlDiv divSearchResults = new HtmlDiv("Id=ires");
    }
}
