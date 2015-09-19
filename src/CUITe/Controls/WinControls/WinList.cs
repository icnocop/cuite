using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a list control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinList : WinControl<CUITControls.WinList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinList"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinList(By searchConfiguration = null)
            : this(new CUITControls.WinList(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinList"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinList(CUITControls.WinList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets an array of indexes for those items in the list that are selected.
        /// </summary>
        public int[] CheckedIndices
        {
            get { return SourceControl.CheckedIndices; }
            set { SourceControl.CheckedIndices = value; }
        }

        /// <summary>
        /// Gets or sets an array of list items that are checked.
        /// </summary>
        public string[] CheckedItems
        {
            get { return SourceControl.CheckedItems; }
            set { SourceControl.CheckedItems = value; }
        }

        /// <summary>
        /// Gets the collection of columns in this list control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Columns
        {
            get { return SourceControl.Columns; }
        }

        /// <summary>
        /// Gets or sets the horizontal scroll bar component of this list control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl HorizontalScrollBar
        {
            get { return SourceControl.HorizontalScrollBar; }
        }

        /// <summary>
        /// Gets a value that indicates whether this list is a checked list.
        /// </summary>
        public bool IsCheckedList
        {
            get { return SourceControl.IsCheckedList; }
        }

        /// <summary>
        /// Gets a value that indicates whether this list control is an icon-view.
        /// </summary>
        public bool IsIconView
        {
            get { return SourceControl.IsIconView; }
        }

        /// <summary>
        /// Gets a value that indicates whether this list is in list-view.
        /// </summary>
        public bool IsListView
        {
            get { return SourceControl.IsListView; }
        }

        /// <summary>
        /// Gets a value that indicates whether this list is enabled for multiple selection.
        /// </summary>
        public bool IsMultipleSelection
        {
            get { return SourceControl.IsMultipleSelection; }
        }

        /// <summary>
        /// Gets a value that indicates whether this list is in report view.
        /// </summary>
        public bool IsReportView
        {
            get { return SourceControl.IsReportView; }
        }

        /// <summary>
        /// Gets a value that indicates whether this list is in small icon-view.
        /// </summary>
        public bool IsSmallIconView
        {
            get { return SourceControl.IsSmallIconView; }
        }

        /// <summary>
        /// Gets the collection of all items in this list.
        /// </summary>
        public IEnumerable<WinListItem> Items
        {
            get
            {
                return SourceControl.Items
                    .Cast<CUITControls.WinListItem>()
                    .Select(item => new WinListItem(item))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets an array of indexes for the selected items in this list.
        /// </summary>
        public int[] SelectedIndices
        {
            get { return SourceControl.SelectedIndices; }
            set { SourceControl.SelectedIndices = value; }
        }

        /// <summary>
        /// Gets an array of the selected items in this list.
        /// </summary>
        public string[] SelectedItems
        {
            get { return SourceControl.SelectedItems; }
            set { SourceControl.SelectedItems = value; }
        }

        /// <summary>
        /// Gets or sets the index for the selected item in this list control.
        /// </summary>
        public int SelectedIndex
        {
            get { return (SelectedIndices.Length > 0 ? SelectedIndices[0] : -1); }
            set { SelectedIndices = new[] { value }; }
        }

        /// <summary>
        /// Gets or sets the selected item in this list control.
        /// </summary>
        public string SelectedItem
        {
            get { return (SelectedIndices.Length > 0 ? SelectedItems[0] : null); }
            set { SelectedItems = new[] { value }; }
        }

        /// <summary>
        /// Gets a string that contains a delimited list of all selected items in this list.
        /// </summary>
        public string SelectedItemsAsString
        {
            get { return SourceControl.SelectedItemsAsString; }
            set { SourceControl.SelectedItemsAsString = value; }
        }

        /// <summary>
        /// Gets the vertical scrollbar component of this list.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl VerticalScrollBar
        {
            get { return SourceControl.VerticalScrollBar; }
        }
    }
}