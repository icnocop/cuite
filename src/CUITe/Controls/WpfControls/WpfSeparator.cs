using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfSeparator
    /// </summary>
    public class WpfSeparator : WpfControl<CUIT.WpfSeparator>
    {
        public WpfSeparator() : base() { }
        public WpfSeparator(string searchParameters) : base(searchParameters) { }
    }
}