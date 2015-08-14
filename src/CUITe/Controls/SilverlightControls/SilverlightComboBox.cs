#if SILVERLIGHT_SUPPORT
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightComboBox.
    /// </summary>
    public class SilverlightComboBox : SilverlightControl<CUITControls.SilverlightComboBox>
    {
        public SilverlightComboBox()
        {
        }

        public SilverlightComboBox(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Selects the item in the combobox.
        /// </summary>
        /// <param name="sItem">Item as string</param>
        public void SelectItem(string sItem)
        {
            _control.WaitForControlReady();
            _control.SelectedItem = sItem;
        }

        /// <summary>
        /// Selects the item in the combobox by index.
        /// </summary>
        /// <param name="index">index of item</param>
        public void SelectItem(int index)
        {
            _control.WaitForControlReady();
            _control.SelectedIndex = index;
        }

        /// <summary>
        /// Gets the selected item in a combobox.
        /// </summary>
        public string SelectedItem
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectedItem;
            }
        }

        /// <summary>
        /// Gets the selected index in a combobox.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                _control.WaitForControlReady();
                return _control.SelectedIndex;
            }
        }

        /// <summary>
        /// Gets the count of the items in the combobox.
        /// </summary>
        public int ItemCount
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Items.Count;
            }
        }

        /// <summary>
        /// Gets the items in a string array.
        /// </summary>
        public string[] Items
        {
            get
            {
                string[] saTemp = new string[ItemCount];
                UITestControlCollection col = _control.Items;
                int i = 0;
                foreach (UITestControl con in col)
                {
                    var it = (CUITControls.SilverlightListItem)con;
                    saTemp[i] = it.Name;
                    i++;
                }
                return saTemp;
            }
        }
    }
}
#endif