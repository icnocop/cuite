using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfCustom
    /// </summary>
    public class WpfCustom : WpfControl<CUITControls.WpfCustom>
    {
        public WpfCustom(string searchProperties = null)
            : this(new CUITControls.WpfCustom(), searchProperties)
        {
        }

        public WpfCustom(CUITControls.WpfCustom sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}