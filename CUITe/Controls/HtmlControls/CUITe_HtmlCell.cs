using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCell : CUITe_HtmlControl<HtmlCell>
    {
        public CUITe_HtmlCell() : base() { }
        public CUITe_HtmlCell(string sSearchProperties) : base(sSearchProperties) { }
        public CUITe_HtmlCell(UITestControl control) : base(control) { }
    }
}
