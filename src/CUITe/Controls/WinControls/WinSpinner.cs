using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSpinner
    /// </summary>
    public class WinSpinner : WinControl<CUIT.WinSpinner>
    {
        public WinSpinner() : base() { }
        public WinSpinner(string searchParameters) : base(searchParameters) { }

        public int MaximumValue
        {
            get { return this.UnWrap().MaximumValue; }
        }

        public int MinimumValue
        {
            get { return this.UnWrap().MinimumValue; }
        }
    }
}