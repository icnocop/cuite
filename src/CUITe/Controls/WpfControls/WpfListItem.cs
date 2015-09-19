using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a list item control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfListItem : WpfControl<CUITControls.WpfListItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfListItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfListItem(By searchConfiguration = null)
            : this(new CUITControls.WpfListItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfListItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfListItem(CUITControls.WpfListItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text from this list item control.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        /// <summary>
        /// Gets a value that indicates whether this list item is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
        }
    }
}