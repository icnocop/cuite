using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinColumnHeader
    /// </summary>
    public class WinColumnHeader : WinControl<CUIT.WinColumnHeader>
    {
        public WinColumnHeader() : base() { }
        public WinColumnHeader(string searchParameters) : base(searchParameters) { }
    }
}