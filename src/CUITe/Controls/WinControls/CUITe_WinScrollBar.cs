using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinScrollBar
    /// </summary>
    public class CUITe_WinScrollBar : CUITe_WinControl<WinScrollBar>
    {
        public CUITe_WinScrollBar() : base() { }
        public CUITe_WinScrollBar(string searchParameters) : base(searchParameters) { }

        public double MaximumPosition
        {
            get { return this.UnWrap().MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return this.UnWrap().MinimumPosition; }
        }

        public double Position
        {
            get { return this.UnWrap().Position; }
        }
    }
}