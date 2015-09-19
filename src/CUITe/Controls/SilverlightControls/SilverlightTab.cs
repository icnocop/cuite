﻿#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a tab control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightTab : SilverlightControl<CUITControls.SilverlightTab>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTab"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTab(By searchConfiguration = null)
            : this(new CUITControls.SilverlightTab(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTab"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTab(CUITControls.SilverlightTab sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the index of the selected tab item.
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
        /// Gets the selected tab item.
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

        // TODO: Get currently selected index
        // TODO: Get currently selected text
        // TODO: Get number of tab items
        // TODO: Tab item enabled or disabled
    }
}
#endif