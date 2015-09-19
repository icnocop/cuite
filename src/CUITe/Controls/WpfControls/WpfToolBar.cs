using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a toolbar control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfToolBar : WpfControl<CUITControls.WpfToolBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfToolBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfToolBar(By searchConfiguration = null)
            : this(new CUITControls.WpfToolBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfToolBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfToolBar(CUITControls.WpfToolBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the header for this toolbar control.
        /// </summary>
        public string Header
        {
            get { return SourceControl.Header; }
        }

        /// <summary>
        /// Gets a collection of items in this tool bar control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }
    }
}