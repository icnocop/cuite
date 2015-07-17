using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlRow : CUITe_HtmlControl<HtmlRow>
    {
        public CUITe_HtmlRow() : base() { }
        public CUITe_HtmlRow(string searchParameters) : base(searchParameters) { }
        public CUITe_HtmlRow(HtmlControl control) : base(control) { }
    }
}
