using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCustom
    /// </summary>
    public class WpfCustom : WpfControl<CUIT.WpfCustom>
    {
        public WpfCustom() : base() { }
        public WpfCustom(string searchParameters) : base(searchParameters) { }
    }
}