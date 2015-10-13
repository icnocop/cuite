using CUITe.ObjectRepository;

namespace Sut.HtmlTest.ObjectRepository
{
    public class HtmlTestPage : Page
    {
        public Div1 Div1
        {
            get { return GetComponent<Div1>(); }
        }
    }
}