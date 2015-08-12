using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class GoogleHomePageWithInvalidControlSearchProperties : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "Google";
        public HtmlDiv controlWithInvalidSearchProperties = new HtmlDiv("blanblah=res");
    }
}
