using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSpinner
    /// </summary>
    public class WinSpinner : WinControl<CUITControls.WinSpinner>
    {
        public WinSpinner(By searchConfiguration = null)
            : this(new CUITControls.WinSpinner(), searchConfiguration)
        {
        }

        public WinSpinner(CUITControls.WinSpinner sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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