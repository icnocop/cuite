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
        public WpfTreeItem(string searchProperties = null)
            : this(new CUITControls.WpfTreeItem(), searchProperties)
        {
        }

        public WpfTreeItem(CUITControls.WpfTreeItem sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool Expanded
        {
            get { return SourceControl.Expanded; }
            set { SourceControl.Expanded = value; }
        }

        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        public string Header
        {
            get { return SourceControl.Header; }
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

        public UITestControl ParentNode
        {
            get { return SourceControl.ParentNode; }
        }

        public bool Selected
        {
            get { return SourceControl.Selected; }
            set { SourceControl.Selected = value; }
        }
    }
}