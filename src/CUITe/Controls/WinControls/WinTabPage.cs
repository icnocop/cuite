using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a tab page control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinTabPage : WinControl<CUITControls.WinTabPage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinTabPage"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTabPage(By searchConfiguration = null)
            : this(new CUITControls.WinTabPage(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinTabPage"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTabPage(CUITControls.WinTabPage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text for the tab page control.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}