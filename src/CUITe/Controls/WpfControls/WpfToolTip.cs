using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolTip
    /// </summary>
    public class WpfToolTip : WpfControl<CUITControls.WpfToolTip>
    {
        public WpfToolTip(string searchProperties = null)
            : this(new CUITControls.WpfToolTip(), searchProperties)
        {
        }

        public WpfToolTip(CUITControls.WpfToolTip sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}