using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a control to test the user interface (UI) of Windows Presentation Foundation
    /// (WPF) applications.
    /// </summary>
    public class WpfControl : WpfControl<CUITControls.WpfControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfControl"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfControl(By searchConfiguration = null)
            : this(new CUITControls.WpfControl(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfControl"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfControl(CUITControls.WpfControl sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}