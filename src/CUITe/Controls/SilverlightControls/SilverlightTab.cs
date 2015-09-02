using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightTab.
    /// </summary>
    public class SilverlightTab : SilverlightControl<CUITControls.SilverlightTab>
    {
        public SilverlightTab(By searchConfiguration = null)
            : this(new CUITControls.SilverlightTab(), searchConfiguration)
        {
        }

        public SilverlightTab(CUITControls.SilverlightTab sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the index of the selected tab item.
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
        /// Gets or sets the text of the selected tab item.
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
        /// Gets the count of tab items.
        /// </summary>
        public int ItemCount
        {
            get
            {
                WaitForControlReady();
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