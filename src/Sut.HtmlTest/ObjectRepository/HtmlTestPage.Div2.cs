using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
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