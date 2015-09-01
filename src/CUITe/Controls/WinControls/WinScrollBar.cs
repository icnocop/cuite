using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinScrollBar
    /// </summary>
    public class WinScrollBar : WinControl<CUITControls.WinScrollBar>
    {
        public WinScrollBar(string searchProperties = null)
            : this(new CUITControls.WinScrollBar(), searchProperties)
        {
        }

        public WinScrollBar(CUITControls.WinScrollBar sourceControl, string searchProperties = null)
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