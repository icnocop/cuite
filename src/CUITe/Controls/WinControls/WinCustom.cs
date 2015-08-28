using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCustom
    /// </summary>
    public class WinCustom : WinControl<CUITControls.WinCustom>
    {
        public WinCustom(CUITControls.WinCustom sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinCustom(), searchProperties)
        {
        }
    }
}