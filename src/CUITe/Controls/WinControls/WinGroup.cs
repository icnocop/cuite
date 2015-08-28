using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinGroup
    /// </summary>
    public class WinGroup : WinControl<CUITControls.WinGroup>
    {
        public WinGroup(string searchProperties = null)
            : this(new CUITControls.WinGroup(), searchProperties)
        {
        }

        public WinGroup(CUITControls.WinGroup sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}