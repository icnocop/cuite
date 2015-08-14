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
        public WpfTree() : base() { }
        public WpfTree(string searchParameters) : base(searchParameters) { }

        public UITestControl HorizontalScrollBar
        {
            get { return UnWrap().HorizontalScrollBar; }
        }

        public UITestControlCollection Nodes
        {
            get { return UnWrap().Nodes; }
        }

        public List<WpfTreeItem> NodesAsCUITe
        {
            get
            {
                List<WpfTreeItem> list = new List<WpfTreeItem>();
                foreach (CUITControls.WpfTreeItem node in UnWrap().Nodes)
                {
                    WpfTreeItem cuiteItem = new WpfTreeItem();
                    cuiteItem.WrapReady(node);
                    list.Add(cuiteItem);
                }
                return list;
            }
        }

        public UITestControl VerticalScrollBar
        {
            get { return UnWrap().VerticalScrollBar; }
        }

    }
}