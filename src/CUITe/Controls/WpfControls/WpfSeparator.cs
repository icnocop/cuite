using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSeparator
    /// </summary>
    public class WpfSeparator : WpfControl<CUITControls.WpfSeparator>
    {
        public WpfSeparator()
        {
        }

        public WpfSeparator(string searchParameters)
            : base(searchParameters)
        {
        }
    }
}