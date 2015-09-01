using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTree
    /// </summary>
    public class WpfTree : WpfControl<CUITControls.WpfTree>
    {
        public WpfTree(string searchProperties = null)
            : this(new CUITControls.WpfTree(), searchProperties)
        {
        }

        public WpfTree(CUITControls.WpfTree sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public UITestControl HorizontalScrollBar
        {
            get { return SourceControl.HorizontalScrollBar; }
        }

        public UITestControlCollection Nodes
        {
            get { return SourceControl.Nodes; }
        }

        public List<WpfTreeItem> NodesAsCUITe
        {
            get
            {
                List<WpfTreeItem> list = new List<WpfTreeItem>();
                foreach (CUITControls.WpfTreeItem node in SourceControl.Nodes)
                {
                    WpfTreeItem cuiteItem = new WpfTreeItem(node);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public UITestControl VerticalScrollBar
        {
            get { return SourceControl.VerticalScrollBar; }
        }

    }
}