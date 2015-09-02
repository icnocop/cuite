using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class Div2 : HtmlDiv
    {
        // TODO: The factory should be able to create instances with default constructor
        // ReSharper disable once UnusedParameter.Local
        // the constructor requires a parameter in order for it to be dynamically created by CUITe
        public Div2(By searchConfiguration)
            : base(By.SearchProperties("id=div2"))
        {
        }

        public HtmlEdit edit
        {
            get
            {
                return Find<HtmlEdit>(By.SearchProperties("id=edit"));
            }
        }
    }
}
