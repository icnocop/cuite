using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinGroup
    /// </summary>
    public class WinGroup : WinControl<CUITControls.WinGroup>
    {
        public WinGroup(CUITControls.WinGroup sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinGroup(), searchProperties)
        {
        }
    }
}