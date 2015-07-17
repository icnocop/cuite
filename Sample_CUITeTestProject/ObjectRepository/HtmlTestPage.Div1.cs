using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class Div1 : CUITe_HtmlDiv
    {
        public Div1()
            : base("id=div1")
        {
        }

        public Div2 div2
        {
            get
            {
                return this.Get<Div2>();
            }
        }
    }
}
