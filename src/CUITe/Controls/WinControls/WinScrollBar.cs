using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinScrollBar
    /// </summary>
    public class WinScrollBar : WinControl<CUITControls.WinScrollBar>
    {
        public WinScrollBar(By searchConfiguration = null)
            : this(new CUITControls.WinScrollBar(), searchConfiguration)
        {
        }

        public WinScrollBar(CUITControls.WinScrollBar sourceControl, By searchConfiguration = null)
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