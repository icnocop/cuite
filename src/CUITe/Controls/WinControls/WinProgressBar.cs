using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinProgressBar
    /// </summary>
    public class WinProgressBar : WinControl<CUITControls.WinProgressBar>
    {
        public WinProgressBar(string searchProperties = null)
            : this(new CUITControls.WinProgressBar(), searchProperties)
        {
        }

        public WinProgressBar(CUITControls.WinProgressBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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