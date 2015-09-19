using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a title bar control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfTitleBar : WpfControl<CUITControls.WpfTitleBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTitleBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTitleBar(By searchConfiguration = null)
            : this(new CUITControls.WpfTitleBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTitleBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTitleBar(CUITControls.WpfTitleBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text for this title bar control.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}