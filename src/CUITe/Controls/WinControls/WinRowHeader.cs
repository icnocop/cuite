using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRowHeader
    /// </summary>
    public class WinRowHeader : WinControl<CUITControls.WinRowHeader>
    {
        public WinRowHeader() : base() { }
        public WinRowHeader(string searchParameters) : base(searchParameters) { }

        public bool Selected
        {
            get { return UnWrap().Selected; }
        }
    }
}