using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class DynamicBrowserWindowTitleRepository : CUITe_DynamicBrowserWindow
    {
        public DynamicBrowserWindowTitleRepository(string title)
            : base(title)
        {

        }

        public DynamicBrowserWindowTitleRepository()
            : this("Clicking the buttons changes the window title")
        {

        }

        public CUITe_HtmlButton btnGoToHomePage = new CUITe_HtmlButton("id=Home");
        public CUITe_HtmlButton btnGoToPage1 = new CUITe_HtmlButton("id=1");
        public CUITe_HtmlButton btnGoToPage2 = new CUITe_HtmlButton("id=2");
        public CUITe_HtmlButton btnChangeWindowTitle = new CUITe_HtmlButton("id=Change Window Title");
    }
}
