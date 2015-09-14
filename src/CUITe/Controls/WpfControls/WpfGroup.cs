using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a group control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfGroup : WpfControl<CUITControls.WpfGroup>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfGroup"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfGroup(By searchConfiguration = null)
            : this(new CUITControls.WpfGroup(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfGroup"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfGroup(CUITControls.WpfGroup sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the contents of the header for this group control.
        /// </summary>
        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}