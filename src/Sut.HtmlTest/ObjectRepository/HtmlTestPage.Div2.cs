using CUITe.Controls.HtmlControls;

namespace Sut.HtmlTest.ObjectRepository
{
    public class Div2 : HtmlDiv
    {
        public Div2()
            : base(searchProperties: "id=div2")
        {
        }

        public HtmlEdit edit
        {
            get
            {
                return Get<HtmlEdit>("id=edit");
            }
        }
    }
}
