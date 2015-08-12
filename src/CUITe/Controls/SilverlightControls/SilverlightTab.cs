#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTab.
    /// </summary>
    public class SilverlightTab : SilverlightControl<CUIT.SilverlightTab>
    {
        public SilverlightTab() : base() { }
        public SilverlightTab(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets or sets the index of the selected tab item.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedIndex;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedIndex = value;
            }
        }

        /// <summary>
        /// Gets or sets the text of the selected tab item.
        /// </summary>
        public string SelectedItem
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.SelectedItem;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets the count of tab items.
        /// </summary>
        public int ItemCount
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Items.Count;
            }
        }

        // get currently selected index

        // get currently selected text

        // get number of tab items

        // tab item enabled or disabled
    }
}
#endif