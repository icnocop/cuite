using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.Mappings
{
    public class Div2 : PageComponent<HtmlDiv>
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