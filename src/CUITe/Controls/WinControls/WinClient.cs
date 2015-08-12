using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinClient
    /// </summary>
    public class WinClient : WinControl<CUIT.WinClient>
    {
        public WinClient() : base() { }
        public WinClient(string searchParameters) : base(searchParameters) { }
    }
}