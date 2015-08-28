using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolTip
    /// </summary>
    public class WpfToolTip : WpfControl<CUITControls.WpfToolTip>
    {
        public WpfToolTip(CUITControls.WpfToolTip sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfToolTip(), searchProperties)
        {
        }
    }
}