using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCheckBoxTreeItem
    /// </summary>
    public class WinCheckBoxTreeItem : WinControl<CUITControls.WinCheckBoxTreeItem>
    {
        public WinCheckBoxTreeItem() { }
        public WinCheckBoxTreeItem(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get { return _control.Checked; }
            set { _control.Checked = value; }
        }

        public bool HasChildNodes
        {
            get { return UnWrap().HasChildNodes; }
        }

        public bool Indeterminate
        {
            get { return _control.Indeterminate; }
            set { _control.Indeterminate = value; }
        }

        public UITestControlCollection Nodes
        {
            get { return UnWrap().Nodes; }
        }

        public UITestControl ParentNode
        {
            get { return UnWrap().ParentNode; }
        }

        public bool Selected
        {
            get { return _control.Selected; }
            set { _control.Selected = value; }
        }

    }
}