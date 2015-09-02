using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfProgressBar
    /// </summary>
    public class WpfProgressBar : WpfControl<CUITControls.WpfProgressBar>
    {
        public WpfProgressBar(By searchConfiguration = null)
            : this(new CUITControls.WpfProgressBar(), searchConfiguration)
        {
        }

        public WpfProgressBar(CUITControls.WpfProgressBar sourceControl, By searchConfiguration = null)
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

        public double Position
        {
            get { return SourceControl.Position; }
        }
    }
}