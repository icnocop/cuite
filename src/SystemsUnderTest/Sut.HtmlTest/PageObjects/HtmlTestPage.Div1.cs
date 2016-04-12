using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    public class Div1 : PageObject<HtmlDiv>
    {
        public Div1()
            : base(By.Id("div1"))
        {
        }

        public Div2 Div2
        {
            get { return GetPageObject<Div2>(); }
        }
    }
}