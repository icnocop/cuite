using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightComboBox.
    /// </summary>
    public class CUITe_SlComboBox : CUITe_SlControl<SilverlightComboBox>
    {
        public CUITe_SlComboBox() : base() { }
        public CUITe_SlComboBox(string searchParameters) : base(searchParameters) { }

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
                return this._control.Items.Count;
            }
        }

        /// <summary>
        /// Gets the items in a string array.
        /// </summary>
        public string[] Items
        {
            get
            {
                string[] saTemp = new string[this.ItemCount];
                UITestControlCollection col = this._control.Items;
                int i = 0;
                foreach (UITestControl con in col)
                {
                    SilverlightListItem it = (SilverlightListItem)con;
                    saTemp[i] = it.Name;
                    i++;
                }
                return saTemp;
            }
        }
    }
}
