using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinGroup
    /// </summary>
    public class WinGroup : WinControl<CUIT.WinGroup>
    {
        public WinGroup() : base() { }
        public WinGroup(string searchParameters) : base(searchParameters) { }
    }
}