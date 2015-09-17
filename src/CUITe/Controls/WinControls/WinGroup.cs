using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a group control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinGroup : WinControl<CUITControls.WinGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinGroup"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinGroup(By searchConfiguration = null)
            : this(new CUITControls.WinGroup(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinGroup"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinGroup(CUITControls.WinGroup sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}