using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinScrollBar
    /// </summary>
    public class WinScrollBar : WinControl<CUITControls.WinScrollBar>
    {
        public WinScrollBar() { }
        public WinScrollBar(string searchParameters) : base(searchParameters) { }

        public double MaximumPosition
        {
            get { return UnWrap().MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return UnWrap().MinimumPosition; }
        }

        public double Position
        {
            get { return UnWrap().Position; }
        }
    }
}