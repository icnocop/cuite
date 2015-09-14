using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a tree control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfTree : WpfControl<CUITControls.WpfTree>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTree"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTree(By searchConfiguration = null)
            : this(new CUITControls.WpfTree(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTree"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTree(CUITControls.WpfTree sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the horizontal scroll bar in this tree control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl HorizontalScrollBar
        {
            get { return SourceControl.HorizontalScrollBar; }
        }

        /// <summary>
        /// Gets a collection of all nodes in this tree control.
        /// </summary>
        public IEnumerable<WpfTreeItem> Nodes
        {
            get
            {
                return SourceControl.Nodes
                    .Cast<CUITControls.WpfTreeItem>()
                    .Select(item => new WpfTreeItem(item))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the vertical scroll bar in this tree control.
        /// </summary>
        public UITestControl VerticalScrollBar
        {
            get { return SourceControl.VerticalScrollBar; }
        }
    }
}