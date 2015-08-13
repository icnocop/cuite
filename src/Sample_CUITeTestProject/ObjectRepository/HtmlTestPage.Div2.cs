using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class Div2 : HtmlDiv
    {
        public Div2()
            : base("id=div2")
        {
        }

        public HtmlEdit edit
        {
            get
            {
                return this.Get<HtmlEdit>("id=edit");
            }
        }
    }
}
