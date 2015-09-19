using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a button control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinPane : WinControl<CUITControls.WinPane>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinPane"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinPane(By searchConfiguration = null)
            : this(new CUITControls.WinPane(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinPane"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinPane(CUITControls.WinPane sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}