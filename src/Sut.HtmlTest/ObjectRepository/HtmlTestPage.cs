using CUITe.Controls.HtmlControls;

namespace Sut.HtmlTest.ObjectRepository
{
    public class HtmlTestPage : BrowserWindowUnderTest
    {
        public HtmlTestPage()
            : base("test")
        {

        }

        public Div1 div1
        {
            get
            {
                return Get<Div1>();
            }
        }
    }
}
