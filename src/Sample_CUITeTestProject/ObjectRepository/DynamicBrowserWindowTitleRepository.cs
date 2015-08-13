using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class DynamicBrowserWindowTitleRepository : DynamicBrowserWindowUnderTest
    {
        public DynamicBrowserWindowTitleRepository(string title)
            : base(title)
        {

        }

        public DynamicBrowserWindowTitleRepository()
            : this("Clicking the buttons changes the window title")
        {

        }

        public HtmlButton btnGoToHomePage
        {
            get
            {
                return this.Get<HtmlButton>("id=Home");
            }
        }

        public HtmlButton btnGoToPage1
        {
            get
            {
                return this.Get<HtmlButton>("id=1");
            }
        }

        public HtmlButton btnGoToPage2
        {
            get
            {
                return this.Get<HtmlButton>("id=2");
            }
        }

        public HtmlButton btnChangeWindowTitle
        {
            get
            {
                return this.Get<HtmlButton>("id=Change Window Title");
            }
        }
    }
}
