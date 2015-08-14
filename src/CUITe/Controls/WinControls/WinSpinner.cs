using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSpinner
    /// </summary>
    public class WinSpinner : WinControl<CUITControls.WinSpinner>
    {
        public WinSpinner() { }
        public WinSpinner(string searchParameters) : base(searchParameters) { }

        public int MaximumValue
        {
            get { return UnWrap().MaximumValue; }
        }

        public int MinimumValue
        {
            get { return UnWrap().MinimumValue; }
        }
    }
}