using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinClient
    /// </summary>
    public class WinClient : WinControl<CUITControls.WinClient>
    {
        public WinClient(string searchProperties = null)
            : this(new CUITControls.WinClient(), searchProperties)
        {
        }

        public WinClient(CUITControls.WinClient sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }
    }
}