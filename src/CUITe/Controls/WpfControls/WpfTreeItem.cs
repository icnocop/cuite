using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfTreeItem
    /// </summary>
    public class WpfTreeItem : WpfControl<CUITControls.WpfTreeItem>
    {
        public WpfTreeItem()
        {
        }

        public WpfTreeItem(string searchParameters)
            : base(searchParameters)
        {
        }

        public bool Expanded
        {
            get { return UnWrap().Expanded; }
            set { UnWrap().Expanded = value; }
        }

        public bool HasChildNodes
        {
            get { return UnWrap().HasChildNodes; }
        }

        public string Header
        {
            get { return UnWrap().Header; }
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