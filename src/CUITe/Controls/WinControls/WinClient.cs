using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinClient
    /// </summary>
    public class WinClient : WinControl<CUITControls.WinClient>
    {
        public WinClient(CUITControls.WinClient sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinClient(), searchProperties)
        {
        }
    }
}