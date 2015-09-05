using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlInputButton : HtmlControl<CUITControls.HtmlInputButton>
    {
        public HtmlInputButton(By searchConfiguration = null)
            : this(new CUITControls.HtmlInputButton(), searchConfiguration)
        {
        }

        public HtmlInputButton(CUITControls.HtmlInputButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}