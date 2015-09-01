using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSeparator
    /// </summary>
    public class WpfSeparator : WpfControl<CUITControls.WpfSeparator>
    {
        public WpfSeparator(string searchProperties = null)
            : this(new CUITControls.WpfSeparator(), searchProperties)
        {
        }

        public WpfSeparator(CUITControls.WpfSeparator sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}