using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a pane control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfPane : WpfControl<CUITControls.WpfPane>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfPane"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfPane(By searchConfiguration = null)
            : this(new CUITControls.WpfPane(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfPane"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfPane(CUITControls.WpfPane sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}