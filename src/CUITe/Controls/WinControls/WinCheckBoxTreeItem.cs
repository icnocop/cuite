using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCheckBoxTreeItem
    /// </summary>
    public class WinCheckBoxTreeItem : WinControl<CUITControls.WinCheckBoxTreeItem>
    {
        public WinCheckBoxTreeItem(string searchProperties = null)
            : this(new CUITControls.WinCheckBoxTreeItem(), searchProperties)
        {
        }

        public WinCheckBoxTreeItem(CUITControls.WinCheckBoxTreeItem sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        public bool HasChildNodes
        {
            get { return SourceControl.HasChildNodes; }
        }

        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }

        public UITestControlCollection Nodes
        {
            get { return SourceControl.Nodes; }
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