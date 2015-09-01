using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlSpan : HtmlControl<CUITControls.HtmlSpan>
    {
        public HtmlSpan(string searchProperties = null)
            : this(new CUITControls.HtmlSpan(), searchProperties)
        {
        }

        public HtmlSpan(CUITControls.HtmlSpan sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}