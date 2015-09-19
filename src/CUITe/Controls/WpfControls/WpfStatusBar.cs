using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a status bar control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfStatusBar : WpfControl<CUITControls.WpfStatusBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfStatusBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfStatusBar(By searchConfiguration = null)
            : this(new CUITControls.WpfStatusBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfStatusBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfStatusBar(CUITControls.WpfStatusBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a collection of panels in this status bar control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}