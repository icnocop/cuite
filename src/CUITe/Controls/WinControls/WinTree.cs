using System.Collections.Generic;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTree
    /// </summary>
    public class WinTree : WinControl<CUITControls.WinTree>
    {
        public WinTree(By searchConfiguration = null)
            : this(new CUITControls.WinTree(), searchConfiguration)
        {
        }

        public WinTree(CUITControls.WinTree sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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