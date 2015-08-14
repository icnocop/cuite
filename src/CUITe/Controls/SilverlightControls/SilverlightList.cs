#if SILVERLIGHT_SUPPORT
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightList.
    /// </summary>
    public class SilverlightList : SilverlightControl<CUITControls.SilverlightList>
    {
        public SilverlightList() : base() { }
        public SilverlightList(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the collection of child list items of the list
        /// </summary>
        public UITestControlCollection Items
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Items;
            }
        }

        /// <summary>
        /// Gets or sets the indices of the selected items of the list.
        /// </summary>
        public int[] SelectedIndices
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectedIndices;
            }
            set
            {
                _control.WaitForControlReady();
                _control.SelectedIndices = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items in the listbox.
        /// </summary>
        public string[] SelectedItems
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectedItems;
            }
            set
            {
                _control.WaitForControlReady();
                _control.SelectedItems = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items of the list in a comma separated format.
        /// </summary>
        public string SelectedItemsAsString
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectedItemsAsString;
            }
            set
            {
                _control.WaitForControlReady();
                _control.SelectedItemsAsString = value;
            }
        }

        /// <summary>
        /// Gets a value indicating the selection mode of the list
        /// </summary>
        public System.Windows.Forms.SelectionMode SelectionMode
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectionMode;
            }
        }
    }
}
#endif