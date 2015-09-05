using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinProgressBar
    /// </summary>
    public class WinProgressBar : WinControl<CUITControls.WinProgressBar>
    {
        public WinProgressBar(By searchConfiguration = null)
            : this(new CUITControls.WinProgressBar(), searchConfiguration)
        {
        }

        public WinProgressBar(CUITControls.WinProgressBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public double MaximumValue
        {
            get { return SourceControl.MaximumValue; }
        }

        public double MinimumValue
        {
            get { return SourceControl.MinimumValue; }
        }

        public double Value
        {
            get { return SourceControl.Value; }
        }
    }
}