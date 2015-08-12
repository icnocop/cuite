using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSeparator
    /// </summary>
    public class WinSeparator : WinControl<CUITControls.WinSeparator>
    {
        public WinSeparator() : base() { }
        public WinSeparator(string searchParameters) : base(searchParameters) { }
    }
}