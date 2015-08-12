using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class GoogleHomePage : CUITe_BrowserWindow
    {
        public new string sWindowTitle = "Google";
        public HtmlEdit txtSearch = new HtmlEdit("Id=lst-ib");
    }
}
