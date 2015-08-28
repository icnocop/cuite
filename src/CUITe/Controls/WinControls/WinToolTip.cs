using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinToolTip
    /// </summary>
    public class WinToolTip : WinControl<CUITControls.WinToolTip>
    {
        public WinToolTip(CUITControls.WinToolTip sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinToolTip(), searchProperties)
        {
        }
    }
}