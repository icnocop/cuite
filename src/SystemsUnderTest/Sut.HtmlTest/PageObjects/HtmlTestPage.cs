using CUITe.PageObjects;

namespace Sut.HtmlTest.PageObjects
{
    public class HtmlTestPage : Page
    {
        public Div1 Div1
        {
            get { return GetPageObject<Div1>(); }
        }
    }
}