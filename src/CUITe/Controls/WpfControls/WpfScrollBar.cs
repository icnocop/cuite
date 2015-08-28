using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfScrollBar
    /// </summary>
    public class WpfScrollBar : WpfControl<CUITControls.WpfScrollBar>
    {
        public WpfScrollBar(CUITControls.WpfScrollBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WpfScrollBar(), searchProperties)
        {
        }

        public double MaximumPosition
        {
            get { return SourceControl.MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return SourceControl.MinimumPosition; }
        }

        public double Position
        {
            get { return SourceControl.Position; }
        }
    }
}