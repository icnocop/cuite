using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDocument : HtmlControl<CUITControls.HtmlDocument>
    {
        public HtmlDocument(string searchProperties = null)
            : this(new CUITControls.HtmlDocument(), searchProperties)
        {
        }

        public HtmlDocument(CUITControls.HtmlDocument sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}