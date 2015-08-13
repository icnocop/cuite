using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfProgressBar
    /// </summary>
    public class WpfProgressBar : WpfControl<CUITControls.WpfProgressBar>
    {
        public WpfProgressBar() : base() { }
        public WpfProgressBar(string searchParameters) : base(searchParameters) { }

        public double MaximumValue
        {
            get { return this.UnWrap().MaximumValue; }
        }

        public double MinimumValue
        {
            get { return this.UnWrap().MinimumValue; }
        }

        public double Position
        {
            get { return this.UnWrap().Position; }
        }
    }
}