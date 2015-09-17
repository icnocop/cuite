using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a client control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinClient : WinControl<CUITControls.WinClient>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinClient"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinClient(By searchConfiguration = null)
            : this(new CUITControls.WinClient(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinClient"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinClient(CUITControls.WinClient sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}