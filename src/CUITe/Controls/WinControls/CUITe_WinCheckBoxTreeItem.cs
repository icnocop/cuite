using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCheckBoxTreeItem
    /// </summary>
    public class CUITe_WinCheckBoxTreeItem : CUITe_WinControl<WinCheckBoxTreeItem>
    {
        public CUITe_WinCheckBoxTreeItem() : base() { }
        public CUITe_WinCheckBoxTreeItem(string searchParameters) : base(searchParameters) { }

        public bool Checked
        {
            get { return this._control.Checked; }
            set { this._control.Checked = value; }
        }

        public bool HasChildNodes
        {
            get { return this.UnWrap().HasChildNodes; }
        }

        public bool Indeterminate
        {
            get { return this._control.Indeterminate; }
            set { this._control.Indeterminate = value; }
        }

        public UITestControlCollection Nodes
        {
            get { return this.UnWrap().Nodes; }
        }

        public UITestControl ParentNode
        {
            get { return this.UnWrap().ParentNode; }
        }

        public bool Selected
        {
            get { return this._control.Selected; }
            set { this._control.Selected = value; }
        }

    }
}