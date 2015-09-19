using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents an edit control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinToolBar : WinControl<CUITControls.WinToolBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinToolBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinToolBar(By searchConfiguration = null)
            : this(new CUITControls.WinToolBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinToolBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinToolBar(CUITControls.WinToolBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a collection of items in this toolbar.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Items
        {
            get { return SourceControl.Items; }
        }
    }
}