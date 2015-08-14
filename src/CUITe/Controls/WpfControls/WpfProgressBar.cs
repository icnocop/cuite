using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfProgressBar
    /// </summary>
    public class WpfProgressBar : WpfControl<CUITControls.WpfProgressBar>
    {
        public WpfProgressBar()
        {
        }

        public WpfProgressBar(string searchParameters)
            : base(searchParameters)
        {
        }

        public double MaximumValue
        {
            get { return UnWrap().MaximumValue; }
        }

        public double MinimumValue
        {
            get { return UnWrap().MinimumValue; }
        }

        public double Position
        {
            get { return UnWrap().Position; }
        }
    }
}