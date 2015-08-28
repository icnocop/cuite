using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTree
    /// </summary>
    public class WinTree : WinControl<CUITControls.WinTree>
    {
        public WinTree(string searchProperties = null)
            : this(new CUITControls.WinTree(), searchProperties)
        {
        }

        public WinTree(CUITControls.WinTree sourceControl, string searchProperties = null)
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

        public List<WinTreeItem> NodesAsCUITe
        {
            get
            {
                List<WinTreeItem> list = new List<WinTreeItem>();
                foreach (CUITControls.WinTreeItem node in SourceControl.Nodes)
                {
                    WinTreeItem cuiteItem = new WinTreeItem(node);
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