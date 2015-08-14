using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRow : HtmlControl<CUITControls.HtmlRow>
    {
        public HtmlRow() { }
        public HtmlRow(string searchParameters) : base(searchParameters) { }
        public HtmlRow(CUITControls.HtmlControl control) : base(control) { }
    }
}
