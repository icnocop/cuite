using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfScrollBar
    /// </summary>
    public class WpfScrollBar : WpfControl<CUITControls.WpfScrollBar>
    {
        public WpfScrollBar() : base() { }
        public WpfScrollBar(string searchParameters) : base(searchParameters) { }

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