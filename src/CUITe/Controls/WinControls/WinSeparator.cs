using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSeparator
    /// </summary>
    public class WinSeparator : WinControl<CUITControls.WinSeparator>
    {
        public WinSeparator(CUITControls.WinSeparator sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinSeparator(), searchProperties)
        {
        }
    }
}