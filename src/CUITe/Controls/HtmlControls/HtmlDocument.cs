using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlDocument : HtmlControl<CUITControls.HtmlDocument>
    {
        public HtmlDocument(By searchConfiguration = null)
            : this(new CUITControls.HtmlDocument(), searchConfiguration)
        {
        }

        public HtmlDocument(CUITControls.HtmlDocument sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}