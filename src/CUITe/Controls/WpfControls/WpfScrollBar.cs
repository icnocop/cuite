using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfScrollBar
    /// </summary>
    public class WpfScrollBar : WpfControl<CUITControls.WpfScrollBar>
    {
        public WpfScrollBar(string searchProperties = null)
            : this(new CUITControls.WpfScrollBar(), searchProperties)
        {
        }

        public WpfScrollBar(CUITControls.WpfScrollBar sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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