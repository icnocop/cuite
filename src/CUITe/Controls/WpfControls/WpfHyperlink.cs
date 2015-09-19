using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a hyperlink control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfHyperlink : WpfControl<CUITControls.WpfHyperlink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfHyperlink"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfHyperlink(By searchConfiguration = null)
            : this(new CUITControls.WpfHyperlink(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfHyperlink"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfHyperlink(CUITControls.WpfHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the alternate text for this hyperlink control.
        /// </summary>
        public string Alt
        {
            get { return SourceControl.Alt; }
        }
    }
}