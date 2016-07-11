using CUITe.SearchConfigurations;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a list control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightList : SilverlightControl<CUITControls.SilverlightList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightList" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightList(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightList(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightList"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightList(CUITControls.SilverlightList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the collection of items in the list.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControlCollection Items
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Items;
            }
        }

        /// <summary>
        /// Gets the indices of the selected items in the list or sets the selected items in the
        /// list with the provided indices.
        /// </summary>
        public int[] SelectedIndices
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.SelectedIndices;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.SelectedIndices = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items.
        /// </summary>
        public string[] SelectedItems
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.SelectedItems;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.SelectedItems = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected items in the list by using a comma-separated string.
        /// </summary>
        public string SelectedItemsAsString
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.SelectedItemsAsString;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.SelectedItemsAsString = value;
            }
        }

        /// <summary>
        /// Gets a value that indicates the selection mode of the list.
        /// </summary>
        public SelectionMode SelectionMode
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.SelectionMode;
            }
        }
    }
}
