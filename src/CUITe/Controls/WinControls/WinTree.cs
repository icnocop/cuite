using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a tree control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinTree : WinControl<CUITControls.WinTree>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinTree"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTree(By searchConfiguration = null)
            : this(new CUITControls.WinTree(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinTree"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTree(CUITControls.WinTree sourceControl, By searchConfiguration = null)
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
        /// Gets a collection of the nodes in this tree control.
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
        /// Gets the vertical scroll bar in this tree control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl VerticalScrollBar
        {
            get { return SourceControl.VerticalScrollBar; }
        }
    }
}