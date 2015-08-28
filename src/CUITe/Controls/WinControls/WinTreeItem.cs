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
        public WinTreeItem(CUITControls.WinTreeItem sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.WinTreeItem(), searchProperties)
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