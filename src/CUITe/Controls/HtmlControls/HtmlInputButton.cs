using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlInputButton : HtmlControl<CUITControls.HtmlInputButton>
    {
        public HtmlInputButton(CUITControls.HtmlInputButton sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlInputButton(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}