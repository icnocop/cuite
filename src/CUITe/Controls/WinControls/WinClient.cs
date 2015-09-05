using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinClient
    /// </summary>
    public class WinClient : WinControl<CUITControls.WinClient>
    {
        public WinClient(By searchConfiguration = null)
            : this(new CUITControls.WinClient(), searchConfiguration)
        {
        }

        public WinClient(CUITControls.WinClient sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}