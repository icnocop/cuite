using System.Collections.Generic;
using System.Linq;
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a tab list control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfTabList : WpfControl<CUITControls.WpfTabList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTabList"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTabList(By searchConfiguration = null)
            : this(new CUITControls.WpfTabList(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTabList"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTabList(CUITControls.WpfTabList sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the index of the selected tab in this tab list control.
        /// </summary>
        public int SelectedIndex
        {
            get { return SourceControl.SelectedIndex; }
            set { SourceControl.SelectedIndex = value; }
        }

        /// <summary>
        /// Gets a collection of tabs in this tab list control.
        /// </summary>
        public IEnumerable<WpfTabPage> Tabs
        {
            get
            {
                return SourceControl.Tabs
                    .Cast<CUITControls.WpfTabPage>()
                    .Select(tab => new WpfTabPage(tab))
                    .ToArray();
            }
        }
    }
}