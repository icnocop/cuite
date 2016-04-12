using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    public class Div2 : PageObject<HtmlDiv>
    {
        public Div2()
            : base(By.Id("div2"))
        {
        }

        public HtmlEdit Edit
        {
            get { return Find<HtmlEdit>(By.Id("edit")); }
        }
    }
}