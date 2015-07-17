using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinClient
    /// </summary>
    public class CUITe_WinClient : CUITe_WinControl<WinClient>
    {
        public CUITe_WinClient() : base() { }
        public CUITe_WinClient(string searchParameters) : base(searchParameters) { }
    }
}