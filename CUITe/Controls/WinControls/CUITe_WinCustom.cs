using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCustom
    /// </summary>
    public class CUITe_WinCustom : CUITe_WinControl<WinCustom>
    {
        public CUITe_WinCustom() : base() { }
        public CUITe_WinCustom(string searchParameters) : base(searchParameters) { }
    }
}