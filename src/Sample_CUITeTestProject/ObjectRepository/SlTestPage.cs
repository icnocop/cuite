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

        public SilverlightList oList
        {
            get
            {
                return Get<SilverlightList>("AutomationId=listBox1");
            }
        }
    }
}
