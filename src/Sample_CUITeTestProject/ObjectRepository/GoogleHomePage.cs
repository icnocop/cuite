using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class GoogleHomePage : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "Google";
        public CUITe_HtmlEdit txtSearch = new CUITe_HtmlEdit("Id=lst-ib");
    }
}
