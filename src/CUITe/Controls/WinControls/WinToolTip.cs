using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinToolTip
    /// </summary>
    public class WinToolTip : WinControl<CUITControls.WinToolTip>
    {
        public WinToolTip(string searchProperties = null)
            : this(new CUITControls.WinToolTip(), searchProperties)
        {
        }

        public WinToolTip(CUITControls.WinToolTip sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}