using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfText
    /// </summary>
    public class WpfText : WpfControl<CUITControls.WpfText>
    {
        public WpfText(string searchProperties = null)
            : this(new CUITControls.WpfText(), searchProperties)
        {
        }

        public WpfText(CUITControls.WpfText sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}