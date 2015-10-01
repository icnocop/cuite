using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.Mappings
{
    public class Div2 : HtmlDiv
    {
        // TODO: The factory should be able to create instances with default constructor
        // ReSharper disable once UnusedParameter.Local
        // the constructor requires a parameter in order for it to be dynamically created by CUITe
        public Div2(By searchConfiguration)
            : base(By.Id("div2"))
        {
        }

        public HtmlEdit Edit
        {
            get { return Find<HtmlEdit>(By.Id("edit")); }
        }
    }
}
