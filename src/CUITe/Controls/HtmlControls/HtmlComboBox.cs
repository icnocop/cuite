using System;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a combo box for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlComboBox : HtmlControl<CUITControls.HtmlComboBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlComboBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlComboBox(By searchConfiguration = null)
            : this(new CUITControls.HtmlComboBox(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlComboBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlComboBox(CUITControls.HtmlComboBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Selects the specified item in the combo box.
        /// </summary>
        /// <param name="item">The item to select.</param>
        public void SelectItem(string item)
        {
            WaitForControlReadyIfNecessary();
            SourceControl.SelectedItem = item;
        }

        /// <summary>
        /// Selects the item in the combo box with specified index.
        /// </summary>
        /// <param name="index">The index of the item to select.</param>
        public void SelectIndex(int index)
        {
            WaitForControlReadyIfNecessary();
            SourceControl.SelectedIndex = index;
        }

        /// <summary>
        /// Gets or sets the selected item in this combo box.
        /// </summary>
        public string SelectedItem
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.SelectedItem;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets or sets the index of the selected item in this combo box.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.SelectedIndex;
            }
            set
            {
                WaitForControlReadyIfNecessary();
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
                WaitForControlReadyIfNecessary();
                return SourceControl.ItemCount;
            }
        }

        /// <summary>
        /// Gets the collection of items in this combo box.
        /// </summary>
        public string[] Items
        {
            get
            {
                // Trying to call InnerText of children will cause errors if child items are
                // disabled
                return InnerText.Split(
                    new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}