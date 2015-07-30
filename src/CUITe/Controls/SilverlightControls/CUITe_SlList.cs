using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightList.
    /// </summary>
    public class CUITe_SlList : CUITe_SlControl<SilverlightList>
    {
        public CUITe_SlList() : base() { }
        public CUITe_SlList(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the collection of child list items of the list
        /// </summary>
        public UITestControlCollection Items
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Items;
            }
        }

        /// <summary>
        /// Gets or sets the indices of the selected items of the list.
        /// </summary>
        public int[] SelectedIndices
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedIndices;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedIndices = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items in the listbox.
        /// </summary>
        public string[] SelectedItems
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedItems;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedItems = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items of the list in a comma separated format.
        /// </summary>
        public string SelectedItemsAsString
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedItemsAsString;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedItemsAsString = value;
            }
        }

        /// <summary>
        /// Gets a value indicating the selection mode of the list
        /// </summary>
        public System.Windows.Forms.SelectionMode SelectionMode
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectionMode;
            }
        }
    }
}
