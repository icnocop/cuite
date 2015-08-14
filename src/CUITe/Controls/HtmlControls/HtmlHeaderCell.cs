using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlHeaderCell : HtmlControl<CUITControls.HtmlHeaderCell>
    {
        public HtmlHeaderCell() { }
        public HtmlHeaderCell(string sSearchProperties) : base(sSearchProperties) { }
        public HtmlHeaderCell(CUITControls.HtmlControl control) : base(control) { }
    }
}
