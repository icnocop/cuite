using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTreeItem
    /// </summary>
    public class CUITe_WinTreeItem : CUITe_WinControl<WinTreeItem>
    {
        public CUITe_WinTreeItem() : base() { }
        public CUITe_WinTreeItem(string searchParameters) : base(searchParameters) { }

        public bool Expanded
        {
            get { return this.UnWrap().Expanded; }
            set { this.UnWrap().Expanded = value; }
        }

        public bool HasChildNodes
        {
            get { return this.UnWrap().HasChildNodes; }
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

        public UITestControl ParentNode
        {
            get { return this.UnWrap().ParentNode; }
        }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
            set { this.UnWrap().Selected = value; }
        }
    }
}