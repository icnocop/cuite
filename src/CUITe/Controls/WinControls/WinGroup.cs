using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinGroup
    /// </summary>
    public class WinGroup : WinControl<CUITControls.WinGroup>
    {
        public WinGroup()
        {
        }

        public WinGroup(string searchParameters)
            : base(searchParameters)
        {
        }
    }
}