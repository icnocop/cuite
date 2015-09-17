using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a menu item control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinMenuItem : WinControl<CUITControls.WinMenuItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinMenuItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinMenuItem(By searchConfiguration = null)
            : this(new CUITControls.WinMenuItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinMenuItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinMenuItem(CUITControls.WinMenuItem sourceControl, By searchConfiguration = null)
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
        /// Gets the text of this menu item.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this menu item has child nodes.
        /// </summary>
        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this menu item is the top-level menu.
        /// </summary>
        public bool IsTopLevelMenu
        {
            get { return SourceControl.IsTopLevelMenu; }
        }

        /// <summary>
        /// Gets the collection of all child items in this menu item.
        /// </summary>
        public IEnumerable<WinMenuItem> Items
        {
            get
            {
                return SourceControl.Items
                    .Cast<CUITControls.WinMenuItem>()
                    .Select(item => new WinMenuItem(item))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the uniform resource identifier (URI) for this menu item.
        /// </summary>
        public string Shortcut
        {
            get { return SourceControl.Shortcut; }
        }
    }
}