using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSeparator
    /// </summary>
    public class WinSeparator : WinControl<CUITControls.WinSeparator>
    {
        public WinSeparator(string searchProperties = null)
            : this(new CUITControls.WinSeparator(), searchProperties)
        {
        }

        public WinSeparator(CUITControls.WinSeparator sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}