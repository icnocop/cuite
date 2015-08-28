using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinScrollBar
    /// </summary>
    public class WinScrollBar : WinControl<CUITControls.WinScrollBar>
    {
        public WinScrollBar(CUITControls.WinScrollBar sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinScrollBar(), searchProperties)
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