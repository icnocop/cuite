using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfScrollBar
    /// </summary>
    public class WpfScrollBar : WpfControl<CUITControls.WpfScrollBar>
    {
        public WpfScrollBar(By searchConfiguration = null)
            : this(new CUITControls.WpfScrollBar(), searchConfiguration)
        {
        }

        public WpfScrollBar(CUITControls.WpfScrollBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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