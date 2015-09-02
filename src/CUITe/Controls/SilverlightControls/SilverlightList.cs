using CUITe.SearchConfigurations;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightList.
    /// </summary>
    public class SilverlightList : SilverlightControl<CUITControls.SilverlightList>
    {
        public SilverlightList(By searchConfiguration = null)
            : this(new CUITControls.SilverlightList(), searchConfiguration)
        {
        }

        public SilverlightList(CUITControls.SilverlightList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the collection of child list items of the list
        /// </summary>
        public UITestControlCollection Items
        {
            get
            {
                WaitForControlReady();
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
                WaitForControlReady();
                return SourceControl.SelectedIndices;
            }
            set
            {
                WaitForControlReady();
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
                WaitForControlReady();
                return SourceControl.SelectedItems;
            }
            set
            {
                WaitForControlReady();
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
                WaitForControlReady();
                return SourceControl.SelectedItemsAsString;
            }
            set
            {
                WaitForControlReady();
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
                WaitForControlReady();
                return SourceControl.SelectionMode;
            }
        }
    }
}
#endif