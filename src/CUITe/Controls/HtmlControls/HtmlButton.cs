using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlButton : HtmlControl<CUITControls.HtmlButton>
    {
        public HtmlButton(string searchProperties = null)
            : this(new CUITControls.HtmlButton(), searchProperties)
        {
        }

        public HtmlButton(CUITControls.HtmlButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}