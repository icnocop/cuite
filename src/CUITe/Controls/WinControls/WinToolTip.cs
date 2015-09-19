using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a tool tip control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinToolTip : WinControl<CUITControls.WinToolTip>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinToolTip"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinToolTip(By searchConfiguration = null)
            : this(new CUITControls.WinToolTip(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinToolTip"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinToolTip(CUITControls.WinToolTip sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}