using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class GoogleSearch : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "coded ui test framework - Google Search";
        public HtmlDiv divSearchResults = new HtmlDiv("Id=ires");
    }
}
