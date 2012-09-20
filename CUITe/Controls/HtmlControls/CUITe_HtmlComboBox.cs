using System.Linq;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// CUITe wrapper for HtmlComboBox.
    /// </summary>
    public class CUITe_HtmlComboBox : CUITe_HtmlControl<HtmlComboBox>
    {
        public CUITe_HtmlComboBox() : base() { }
        public CUITe_HtmlComboBox(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Selects the item in the combobox.
        /// </summary>
        /// <param name="sItem">Item as string</param>
        public void SelectItem(string sItem)
        {
            this._control.WaitForControlReady();
            this._control.SelectedItem = sItem;
        }

        /// <summary>
        /// Selects the item in the combobox by index.
        /// </summary>
        /// <param name="index">index of item</param>
        public void SelectItem(int index)
        {
            this._control.WaitForControlReady();
            this._control.SelectedIndex = index;
        }

        /// <summary>
        /// Gets the selected item in a combobox.
        /// </summary>
        public string SelectedItem
        {
            get 
            {
                this._control.WaitForControlReady();
                return this._control.SelectedItem; 
            }
        }

        /// <summary>
        /// Gets the selected index in a combobox.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedIndex;
            }
        }

        /// <summary>
        /// Gets the count of the items in the combobox.
        /// </summary>
        public int ItemCount
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ItemCount;
            }
        }

        /// <summary>
        /// Gets the items in a string array of the html combo box.
        /// </summary>
        public string[] Items
        {
            get
            {
                return GetPropertyOfChildren<string>(HtmlControl.PropertyNames.InnerText);
            }
        }

        /// <summary>
        /// Tells whether the specified item is present in the html combo box or not.
        /// </summary>
        public bool ItemExists(string sText)
        {
            return this.Items.Contains<string>(sText);
        }
    }
}
