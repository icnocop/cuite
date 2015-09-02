using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightComboBox.
    /// </summary>
    public class SilverlightComboBox : SilverlightControl<CUITControls.SilverlightComboBox>
    {
        public SilverlightComboBox(By searchConfiguration = null)
            : this(new CUITControls.SilverlightComboBox(), searchConfiguration)
        {
        }

        public SilverlightComboBox(CUITControls.SilverlightComboBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Selects the item in the combobox.
        /// </summary>
        /// <param name="sItem">Item as string</param>
        public void SelectItem(string sItem)
        {
            WaitForControlReady();
            SourceControl.SelectedItem = sItem;
        }

        /// <summary>
        /// Selects the item in the combobox by index.
        /// </summary>
        /// <param name="index">index of item</param>
        public void SelectItem(int index)
        {
            WaitForControlReady();
            SourceControl.SelectedIndex = index;
        }

        /// <summary>
        /// Gets the selected item in a combobox.
        /// </summary>
        public string SelectedItem
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectedItem;
            }
        }

        /// <summary>
        /// Gets the selected index in a combobox.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                WaitForControlReady();
                return SourceControl.SelectedIndex;
            }
        }

        /// <summary>
        /// Gets the count of the items in the combobox.
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
        /// Gets the items in a string array.
        /// </summary>
        public string[] Items
        {
            get
            {
                string[] saTemp = new string[ItemCount];
                UITestControlCollection col = SourceControl.Items;
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