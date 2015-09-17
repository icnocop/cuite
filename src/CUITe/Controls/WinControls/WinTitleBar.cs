using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents title bar control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinTitleBar : WinControl<CUITControls.WinTitleBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinTitleBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTitleBar(By searchConfiguration = null)
            : this(new CUITControls.WinTitleBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinTitleBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTitleBar(CUITControls.WinTitleBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text of this title bar.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}