using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTree
    /// </summary>
    public class CUITe_WpfTree : CUITe_WpfControl<WpfTree>
    {
        public CUITe_WpfTree() : base() { }
        public CUITe_WpfTree(string searchParameters) : base(searchParameters) { }

        public UITestControl HorizontalScrollBar
        {
            get { return this.UnWrap().HorizontalScrollBar; }
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

        public UITestControl VerticalScrollBar
        {
            get { return this.UnWrap().VerticalScrollBar; }
        }

    }
}