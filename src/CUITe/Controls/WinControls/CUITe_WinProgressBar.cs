using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinProgressBar
    /// </summary>
    public class CUITe_WinProgressBar : CUITe_WinControl<WinProgressBar>
    {
        public CUITe_WinProgressBar() : base() { }
        public CUITe_WinProgressBar(string searchParameters) : base(searchParameters) { }

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