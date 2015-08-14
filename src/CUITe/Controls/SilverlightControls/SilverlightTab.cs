#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTab.
    /// </summary>
    public class SilverlightTab : SilverlightControl<CUITControls.SilverlightTab>
    {
        public SilverlightTab()
        {
        }

        public SilverlightTab(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Gets or sets the index of the selected tab item.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedIndex;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedIndex = value;
            }
        }

        /// <summary>
        /// Gets or sets the text of the selected tab item.
        /// </summary>
        public string SelectedItem
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.SelectedItem;
            }
            set
            {
                SourceControl.WaitForControlReady();
                SourceControl.SelectedItem = value;
            }
        }

        /// <summary>
        /// Gets the count of tab items.
        /// </summary>
        public int ItemCount
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Items.Count;
            }
        }

        // get currently selected index

        // get currently selected text

        // get number of tab items

        // tab item enabled or disabled
    }
}
#endif