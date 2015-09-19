using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a list item control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinListItem : WinControl<CUITControls.WinListItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinListItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinListItem(By searchConfiguration = null)
            : this(new CUITControls.WinListItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinListItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinListItem(CUITControls.WinListItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the text of the item.
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