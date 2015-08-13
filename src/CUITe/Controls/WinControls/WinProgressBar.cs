using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinProgressBar
    /// </summary>
    public class WinProgressBar : WinControl<CUITControls.WinProgressBar>
    {
        public WinProgressBar() : base() { }
        public WinProgressBar(string searchParameters) : base(searchParameters) { }

        public double MaximumValue
        {
            get { return this.UnWrap().MaximumValue; }
        }

        public double MinimumValue
        {
            get { return this.UnWrap().MinimumValue; }
        }

        public double Value
        {
            get { return this.UnWrap().Value; }
        }
    }
}