using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfText
    /// </summary>
    public class WpfText : WpfControl<CUITControls.WpfText>
    {
        public WpfText(CUITControls.WpfText sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfText(), searchProperties)
        {
        }

        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}