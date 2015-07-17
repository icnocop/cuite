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

        public CUITe_HtmlButton btnGoToHomePage
        {
            get
            {
                return this.Get<CUITe_HtmlButton>("id=Home");
            }
        }

        public CUITe_HtmlButton btnGoToPage1
        {
            get
            {
                return this.Get<CUITe_HtmlButton>("id=1");
            }
        }

        public CUITe_HtmlButton btnGoToPage2
        {
            get
            {
                return this.Get<CUITe_HtmlButton>("id=2");
            }
        }

        public CUITe_HtmlButton btnChangeWindowTitle
        {
            get
            {
                return this.Get<CUITe_HtmlButton>("id=Change Window Title");
            }
        }
    }
}
