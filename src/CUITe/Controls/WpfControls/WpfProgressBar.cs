using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfProgressBar
    /// </summary>
    public class WpfProgressBar : WpfControl<CUITControls.WpfProgressBar>
    {
        public WpfProgressBar(CUITControls.WpfProgressBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfProgressBar(), searchProperties)
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