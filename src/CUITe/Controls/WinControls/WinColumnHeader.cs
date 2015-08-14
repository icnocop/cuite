using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinColumnHeader
    /// </summary>
    public class WinColumnHeader : WinControl<CUITControls.WinColumnHeader>
    {
        public WinColumnHeader() { }
        public WinColumnHeader(string searchParameters) : base(searchParameters) { }
    }
}