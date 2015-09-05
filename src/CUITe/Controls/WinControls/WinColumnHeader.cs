using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinColumnHeader
    /// </summary>
    public class WinColumnHeader : WinControl<CUITControls.WinColumnHeader>
    {
        public WinColumnHeader(By searchConfiguration = null)
            : this(new CUITControls.WinColumnHeader(), searchConfiguration)
        {
        }

        public WinColumnHeader(CUITControls.WinColumnHeader sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}