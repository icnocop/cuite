using CUITe.Controls.HtmlControls;
using CUITe.Controls.SilverlightControls;

namespace Sut.SilverlightTest.ObjectRepository
{
    public class SlTestPage : BrowserWindowUnderTest
    {
        public SlTestPage()
            : base("Home")
        {
        }

        public SilverlightList oList
        {
            get { return Get<SilverlightList>("AutomationId=listBox1"); }
        }
    }
}