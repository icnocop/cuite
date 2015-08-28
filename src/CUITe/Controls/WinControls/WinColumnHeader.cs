using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinColumnHeader
    /// </summary>
    public class WinColumnHeader : WinControl<CUITControls.WinColumnHeader>
    {
        public WinColumnHeader(CUITControls.WinColumnHeader sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinColumnHeader(), searchProperties)
        {
        }
    }
}