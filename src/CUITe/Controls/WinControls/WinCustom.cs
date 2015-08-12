using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCustom
    /// </summary>
    public class WinCustom : WinControl<CUIT.WinCustom>
    {
        public WinCustom() : base() { }
        public WinCustom(string searchParameters) : base(searchParameters) { }
    }
}