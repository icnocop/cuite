using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a tab page control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfTabPage : WpfControl<CUITControls.WpfTabPage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTabPage"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTabPage(By searchConfiguration = null)
            : this(new CUITControls.WpfTabPage(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfTabPage"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfTabPage(CUITControls.WpfTabPage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the header for this tab page.
        /// </summary>
        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}