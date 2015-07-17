using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class Div2 : CUITe_HtmlDiv
    {
        public Div2()
            : base("id=div2")
        {
        }

        public CUITe_HtmlEdit edit
        {
            get
            {
                return this.Get<CUITe_HtmlEdit>("id=edit");
            }
        }
    }
}
