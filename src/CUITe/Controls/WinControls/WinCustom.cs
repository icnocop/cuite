using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCustom
    /// </summary>
    public class WinCustom : WinControl<CUITControls.WinCustom>
    {
        public WinCustom(string searchProperties = null)
            : this(new CUITControls.WinCustom(), searchProperties)
        {
        }

        public WinCustom(CUITControls.WinCustom sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}