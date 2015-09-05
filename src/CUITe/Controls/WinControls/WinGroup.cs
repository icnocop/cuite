using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinGroup
    /// </summary>
    public class WinGroup : WinControl<CUITControls.WinGroup>
    {
        public WinGroup(By searchConfiguration = null)
            : this(new CUITControls.WinGroup(), searchConfiguration)
        {
        }

        public WinGroup(CUITControls.WinGroup sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}