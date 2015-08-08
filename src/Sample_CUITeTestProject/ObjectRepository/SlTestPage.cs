using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class SlTestPage : CUITe_BrowserWindow
    {
        public SlTestPage()
            : base("Home")
        {

        }

        public CUITe_SlList oList
        {
            get
            {
                return Get<CUITe_SlList>("AutomationId=listBox1");
            }
        }
    }
}
