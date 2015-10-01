using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.Mappings
{
    public class Div1 : HtmlDiv
    {
        // TODO: The factory should be able to create instances with default constructor
        // ReSharper disable once UnusedParameter.Local
        // the constructor requires a parameter in order for it to be dynamically created by CUITe
        public Div1(By searchConfiguration)
            : base(By.Id("div1"))
        {
        }

        public Div2 Div2
        {
            get { return Find<Div2>(); }
        }
    }
}