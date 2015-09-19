using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a separator control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfSeparator : WpfControl<CUITControls.WpfSeparator>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfSeparator"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfSeparator(By searchConfiguration = null)
            : this(new CUITControls.WpfSeparator(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfSeparator"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfSeparator(CUITControls.WpfSeparator sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}