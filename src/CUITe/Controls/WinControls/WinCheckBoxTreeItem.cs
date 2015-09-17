using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a check box tree item control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinCheckBoxTreeItem : WinControl<CUITControls.WinCheckBoxTreeItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinCheckBoxTreeItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCheckBoxTreeItem(By searchConfiguration = null)
            : this(new CUITControls.WinCheckBoxTreeItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinCheckBoxTreeItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCheckBoxTreeItem(CUITControls.WinCheckBoxTreeItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the tree item is checked.
        /// </summary>
        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether the tree item has child nodes.
        /// </summary>
        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the check box state is indeterminate.
        /// </summary>
        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }

        /// <summary>
        /// Gets a collection of nodes in this check box tree item.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Nodes
        {
            get { return SourceControl.Nodes; }
        }

        /// <summary>
        /// Gets the parent node of this check box tree item.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl ParentNode
        {
            get { return SourceControl.ParentNode; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this check box tree item is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
            set { SourceControl.Selected = value; }
        }
    }
}