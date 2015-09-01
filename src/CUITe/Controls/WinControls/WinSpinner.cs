using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSpinner
    /// </summary>
    public class WinSpinner : WinControl<CUITControls.WinSpinner>
    {
        public WinSpinner(string searchProperties = null)
            : this(new CUITControls.WinSpinner(), searchProperties)
        {
        }

        public WinSpinner(CUITControls.WinSpinner sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public int MaximumValue
        {
            get { return SourceControl.MaximumValue; }
        }

        public int MinimumValue
        {
            get { return SourceControl.MinimumValue; }
        }
    }
}