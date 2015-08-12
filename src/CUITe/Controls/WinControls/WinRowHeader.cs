using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRowHeader
    /// </summary>
    public class WinRowHeader : WinControl<CUIT.WinRowHeader>
    {
        public WinRowHeader() : base() { }
        public WinRowHeader(string searchParameters) : base(searchParameters) { }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
        }
    }
}