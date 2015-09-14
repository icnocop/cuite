using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a menu item control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfMenuItem : WpfControl<CUITControls.WpfMenuItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfMenuItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfMenuItem(By searchConfiguration = null)
            : this(new CUITControls.WpfMenuItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfMenuItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfMenuItem(CUITControls.WpfMenuItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this menu item is checked.
        /// </summary>
        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this menu item is expanded.
        /// </summary>
        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this menu item has child nodes.
        /// </summary>
        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        /// <summary>
        /// Gets the contents of the header for this menu item control.
        /// </summary>
        public string Header
        {
            get { return SourceControl.Header; }
        }

        /// <summary>
        /// Gets a value that indicates whether this menu item is a top-level menu.
        /// </summary>
        public bool IsTopLevelMenu
        {
            get { return SourceControl.IsTopLevelMenu; }
        }
    }
}