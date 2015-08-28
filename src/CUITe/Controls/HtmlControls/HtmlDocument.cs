using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDocument : HtmlControl<CUITControls.HtmlDocument>
    {
        public HtmlDocument(CUITControls.HtmlDocument sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlDocument(), searchProperties)
        {
        }
    }
}