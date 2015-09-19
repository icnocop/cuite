using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a tree item control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinTreeItem : WinControl<CUITControls.WinTreeItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinTreeItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTreeItem(By searchConfiguration = null)
            : this(new CUITControls.WinTreeItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinTreeItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTreeItem(CUITControls.WinTreeItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this tree item is expanded.
        /// </summary>
        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this tree item has child items.
        /// </summary>
        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        /// <summary>
        /// Gets a collection of child controls of this tree item.
        /// </summary>
        public IEnumerable<WinTreeItem> Nodes
        {
            get
            {
                return SourceControl.Nodes
                    .Cast<CUITControls.WinTreeItem>()
                    .Select(node => new WinTreeItem(node))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the control at the parent node of this tree item.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl ParentNode
        {
            get { return SourceControl.ParentNode; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this tree item is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
            set { SourceControl.Selected = value; }
        }
    }
}