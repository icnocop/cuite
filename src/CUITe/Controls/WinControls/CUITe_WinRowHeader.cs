using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinRowHeader
    /// </summary>
    public class CUITe_WinRowHeader : CUITe_WinControl<WinRowHeader>
    {
        public CUITe_WinRowHeader() : base() { }
        public CUITe_WinRowHeader(string searchParameters) : base(searchParameters) { }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
        }
    }
}