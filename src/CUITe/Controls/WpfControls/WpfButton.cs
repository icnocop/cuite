using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a button control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfButton : WpfControl<CUITControls.WpfButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfButton(By searchConfiguration = null)
            : this(new CUITControls.WpfButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfButton(CUITControls.WpfButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the text of this button.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}