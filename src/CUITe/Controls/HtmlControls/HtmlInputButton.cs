using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlInputButton : HtmlControl<CUITControls.HtmlInputButton>
    {
        public HtmlInputButton(string searchProperties = null)
            : this(new CUITControls.HtmlInputButton(), searchProperties)
        {
        }

        public HtmlInputButton(CUITControls.HtmlInputButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}