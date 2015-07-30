using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTree
    /// </summary>
    public class CUITe_WinTree : CUITe_WinControl<WinTree>
    {
        public CUITe_WinTree() : base() { }
        public CUITe_WinTree(string searchParameters) : base(searchParameters) { }

        public UITestControl HorizontalScrollBar
        {
            get { return this.UnWrap().HorizontalScrollBar; }
        }

        public UITestControlCollection Nodes
        {
            get { return this.UnWrap().Nodes; }
        }

        public List<CUITe_WinTreeItem> NodesAsCUITe
        {
            get
            {
                List<CUITe_WinTreeItem> list = new List<CUITe_WinTreeItem>();
                foreach (WinTreeItem node in this.UnWrap().Nodes)
                {
                    CUITe_WinTreeItem cuiteItem = new CUITe_WinTreeItem();
                    cuiteItem.WrapReady(node);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public UITestControl VerticalScrollBar
        {
            get { return this.UnWrap().VerticalScrollBar; }
        }
    }
}