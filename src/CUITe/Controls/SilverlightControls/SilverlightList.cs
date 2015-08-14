#if SILVERLIGHT_SUPPORT
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightList.
    /// </summary>
    public class SilverlightList : SilverlightControl<CUITControls.SilverlightList>
    {
        public SilverlightList()
        {
        }

        public SilverlightList(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Gets the collection of child list items of the list
        /// </summary>
        public UITestControlCollection Items
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Items;
            }
        }

        /// <summary>
        /// Gets or sets the indices of the selected items of the list.
        /// </summary>
        public int[] SelectedIndices
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedIndices;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedIndices = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items in the listbox.
        /// </summary>
        public string[] SelectedItems
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedItems;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedItems = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items of the list in a comma separated format.
        /// </summary>
        public string SelectedItemsAsString
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedItemsAsString;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedItemsAsString = value;
            }
        }

        /// <summary>
        /// Gets a value indicating the selection mode of the list
        /// </summary>
        public SelectionMode SelectionMode
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectionMode;
            }
        }
    }
}
#endif