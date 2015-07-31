using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class HtmlTestPage : CUITe_BrowserWindow
    {
        public HtmlTestPage()
            : base("test")
        {

        }

        public Div1 div1
        {
            get
            {
                return this.Get<Div1>();
            }
        }
    }
}
