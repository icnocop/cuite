using CUITe.Mappings;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.HtmlTest.Mappings
{
    public class HtmlTestPage : Page
    {
        public HtmlTestPage(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        public Div1 Div1
        {
            get { return Find<Div1>(); }
        }
    }
}