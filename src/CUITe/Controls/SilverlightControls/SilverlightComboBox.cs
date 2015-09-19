﻿#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a combo box control to test the user interface (UI) of a Silverlight
    /// application.
    /// </summary>
    public class SilverlightComboBox : SilverlightControl<CUITControls.SilverlightComboBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightComboBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightComboBox(By searchConfiguration = null)
            : this(new CUITControls.SilverlightComboBox(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightComboBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightComboBox(CUITControls.SilverlightComboBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Selects the specified item in the combo box.
        /// </summary>
        /// <param name="item">The item to select.</param>
        public void SelectItem(string item)
        {
            WaitForControlReady();
            SourceControl.SelectedItem = item;
        }

        /// <summary>
        /// Selects the item in the combo box with specified index.
        /// </summary>
        /// <param name="index">The index of the item to select.</param>
        public void SelectIndex(int index)
        {
            WaitForControlReady();
            SourceControl.SelectedIndex = index;
        }

        /// <summary>
        /// Gets or sets the selected item in the combo box.
        /// </summary>
        public string SelectedItem
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectedItem;
            }
            set
            {
                WaitForControlReady();
                SourceControl.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets or sets the index of the selected item.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectedIndex;
            }
            set
            {
                WaitForControlReady();
                SourceControl.SelectedIndex = value;
            }
        }

        /// <summary>
        /// Gets the count of the items in the combo box.
        /// </summary>
        public int ItemCount
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Items.Count;
            }
        }

        /// <summary>
        /// Gets the list of items in the combo box.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public virtual UITestControlCollection Items
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Items;
            }
        }
    }
}
#endif