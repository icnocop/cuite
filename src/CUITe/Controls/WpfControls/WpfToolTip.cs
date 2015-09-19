using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a tool tip control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfToolTip : WpfControl<CUITControls.WpfToolTip>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfToolTip"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfToolTip(By searchConfiguration = null)
            : this(new CUITControls.WpfToolTip(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfToolTip"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfToolTip(CUITControls.WpfToolTip sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}