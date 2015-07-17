using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTreeItem
    /// </summary>
    public class CUITe_WpfTreeItem : CUITe_WpfControl<WpfTreeItem>
    {
        public CUITe_WpfTreeItem() : base() { }
        public CUITe_WpfTreeItem(string searchParameters) : base(searchParameters) { }

        public bool Expanded
        {
            get { return this.UnWrap().Expanded; }
            set { this.UnWrap().Expanded = value; }
        }

        public bool HasChildNodes
        {
            get { return this.UnWrap().HasChildNodes; }
        }

        public string Header
        {
            get { return this.UnWrap().Header; }
        }

        public UITestControlCollection Nodes
        {
            get { return this.UnWrap().Nodes; }
        }

        public List<CUITe_WpfTreeItem> NodesAsCUITe
        {
            get
            {
                List<CUITe_WpfTreeItem> list = new List<CUITe_WpfTreeItem>();
                foreach (WpfTreeItem node in this.UnWrap().Nodes)
                {
                    CUITe_WpfTreeItem cuiteItem = new CUITe_WpfTreeItem();
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