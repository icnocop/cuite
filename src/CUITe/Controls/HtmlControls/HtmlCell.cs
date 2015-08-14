using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlCell : HtmlControl<CUITControls.HtmlCell>
    {
        public HtmlCell() { }
        public HtmlCell(string sSearchProperties) : base(sSearchProperties) { }
        public HtmlCell(UITestControl control) : base(control) { }
    }
}
