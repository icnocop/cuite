using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinTreeItem
    /// </summary>
    public class WinTreeItem : WinControl<CUITControls.WinTreeItem>
    {
        public WinTreeItem() { }
        public WinTreeItem(string searchParameters) : base(searchParameters) { }

        public bool Expanded
        {
            get { return UnWrap().Expanded; }
            set { UnWrap().Expanded = value; }
        }

        public bool HasChildNodes
        {
            get { return UnWrap().HasChildNodes; }
        }

        public UITestControlCollection Nodes
        {
            get { return UnWrap().Nodes; }
        }

        public List<WinTreeItem> NodesAsCUITe
        {
            get
            {
                List<WinTreeItem> list = new List<WinTreeItem>();
                foreach (CUITControls.WinTreeItem node in UnWrap().Nodes)
                {
                    WinTreeItem cuiteItem = new WinTreeItem();
                    cuiteItem.WrapReady(node);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public UITestControl ParentNode
        {
            get { return UnWrap().ParentNode; }
        }

        public bool Selected
        {
            get { return UnWrap().Selected; }
            set { UnWrap().Selected = value; }
        }
    }
}