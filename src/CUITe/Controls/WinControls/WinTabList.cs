using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a tab list control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinTabList : WinControl<CUITControls.WinTabList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinTabList"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTabList(By searchConfiguration = null)
            : this(new CUITControls.WinTabList(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinTabList"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinTabList(CUITControls.WinTabList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the index of the selected item in the tab list.
        /// </summary>
        public int SelectedIndex
        {
            get { return SourceControl.SelectedIndex; }
            set { SourceControl.SelectedIndex = value; }
        }

        /// <summary>
        /// Gets a collection of tab controls in this tab list.
        /// </summary>
        public IEnumerable<WinTabPage> Tabs
        {
            get
            {
                return SourceControl.Tabs
                    .Cast<CUITControls.WinTabPage>()
                    .Select(tab => new WinTabPage(tab))
                    .ToArray();
            }
        }

        /// <summary>
        /// Gets the spinner component of this tab control.
        /// </summary>
        // TODO: Wrap these into CUITe controls
        public UITestControl TabSpinner
        {
            get { return SourceControl.TabSpinner; }
        }
    }
}