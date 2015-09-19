using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a separator control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinSeparator : WinControl<CUITControls.WinSeparator>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinSeparator"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSeparator(By searchConfiguration = null)
            : this(new CUITControls.WinSeparator(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinSeparator"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSeparator(CUITControls.WinSeparator sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}