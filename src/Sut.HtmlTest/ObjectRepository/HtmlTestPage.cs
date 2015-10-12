using CUITe.ObjectRepository;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.HtmlTest.ObjectRepository
{
    public class HtmlTestPage : Page
    {
        public HtmlTestPage(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        public Div1 Div1
        {
            get { return GetComponent<Div1>(); }
        }
    }
}