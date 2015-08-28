using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinColumnHeader
    /// </summary>
    public class WinColumnHeader : WinControl<CUITControls.WinColumnHeader>
    {
        public WinColumnHeader(string searchProperties = null)
            : this(new CUITControls.WinColumnHeader(), searchProperties)
        {
        }

        public WinColumnHeader(CUITControls.WinColumnHeader sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}