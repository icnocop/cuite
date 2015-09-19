using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a status bar control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinStatusBar : WinControl<CUITControls.WinStatusBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinStatusBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinStatusBar(By searchConfiguration = null)
            : this(new CUITControls.WinStatusBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinStatusBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinStatusBar(CUITControls.WinStatusBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
        
        /// <summary>
        /// Gets a collection of panels in this status bar.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Panels
        {
            get { return SourceControl.Panels; }
        }
    }
}