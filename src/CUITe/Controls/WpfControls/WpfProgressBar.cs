using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfProgressBar
    /// </summary>
    public class WpfProgressBar : WpfControl<CUITControls.WpfProgressBar>
    {
        public WpfProgressBar(string searchProperties = null)
            : this(new CUITControls.WpfProgressBar(), searchProperties)
        {
        }

        public WpfProgressBar(CUITControls.WpfProgressBar sourceControl, string searchProperties = null)
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

        public double Position
        {
            get { return SourceControl.Position; }
        }
    }
}