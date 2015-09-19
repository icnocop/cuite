using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a list control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfList : WpfControl<CUITControls.WpfList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfList"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfList(By searchConfiguration = null)
            : this(new CUITControls.WpfList(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfList"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfList(CUITControls.WpfList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets a value that indicates whether this list control can have multiple selections.
        /// </summary>
        public bool IsMultipleSelection
        {
            get { return SourceControl.IsMultipleSelection; }
        }

        
        /// <summary>
        /// Gets a collection of items in this list control.
        /// </summary>
        public IEnumerable<WpfListItem> Items
        {
            get
            {
                return SourceControl.Items
                    .Cast<CUITControls.WpfListItem>()
                    .Select(item => new WpfListItem(item))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets an array of indexes for the selected items in this list control.
        /// </summary>
        public int[] SelectedIndices
        {
            get { return SourceControl.SelectedIndices; }
            set { SourceControl.SelectedIndices = value; }
        }

        /// <summary>
        /// Gets or sets an array of the selected items in this list control.
        /// </summary>
        public string[] SelectedItems
        {
            get { return SourceControl.SelectedItems; }
            set { SourceControl.SelectedItems = value; }
        }

        /// <summary>
        /// Gets or sets the selected items in this list control as a string.
        /// </summary>
        public string SelectedItemsAsString
        {
            get { return SourceControl.SelectedItemsAsString; }
            set { SourceControl.SelectedItemsAsString = value; }
        }

        /// <summary>
        /// Gets or sets the index for the selected item in this list control.
        /// </summary>
        public int SelectedIndex
        {
            get { return SelectedIndices.Length > 0 ? SelectedIndices[0] : -1; }
            set { SelectedIndices = new[] { value }; }
        }

        /// <summary>
        /// Gets or sets the selected item in this list control.
        /// </summary>
        public string SelectedItem
        {
            get { return SelectedIndices.Length > 0 ? SelectedItems[0] : null; }
            set { SelectedItems = new[] { value }; }
        }
    }
}