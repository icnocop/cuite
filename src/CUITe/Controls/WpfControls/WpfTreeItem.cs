using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a tree item control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfTreeItem : WpfControl<CUITControls.WpfTreeItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTreeItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTreeItem(By searchConfiguration = null)
            : this(new CUITControls.WpfTreeItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTreeItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTreeItem(CUITControls.WpfTreeItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether this tree item is expanded.
        /// </summary>
        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this tree item has child nodes.
        /// </summary>
        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        /// <summary>
        /// Gets the header text for this tree item control.
        /// </summary>
        public string Header
        {
            get { return SourceControl.Header; }
        }

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<WpfTreeItem> Nodes
        {
            get
            {
                return SourceControl.Nodes
                    .Cast<CUITControls.WpfTreeItem>()
                    .Select(node => new WpfTreeItem(node))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the parent node of this tree item control.
        /// </summary>
        public UITestControl ParentNode
        {
            get { return SourceControl.ParentNode; }
        }

        /// <summary>
        /// Gets a value that indicates whether this tree item control is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
            set { SourceControl.Selected = value; }
        }
    }
}