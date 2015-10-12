using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class Div1 : PageComponent<HtmlDiv>
    {
        public Div1()
            : base(By.Id("div1"))
        {
        }

        public Div2 Div2
        {
            get { return GetComponent<Div2>(); }
        }
    }
}