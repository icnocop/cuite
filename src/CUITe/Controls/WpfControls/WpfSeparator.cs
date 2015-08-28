using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSeparator
    /// </summary>
    public class WpfSeparator : WpfControl<CUITControls.WpfSeparator>
    {
        public WpfSeparator(CUITControls.WpfSeparator sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfSeparator(), searchProperties)
        {
        }
    }
}