using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCustom
    /// </summary>
    public class WpfCustom : WpfControl<CUITControls.WpfCustom>
    {
        public WpfCustom(CUITControls.WpfCustom sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfCustom(), searchProperties)
        {
        }
    }
}