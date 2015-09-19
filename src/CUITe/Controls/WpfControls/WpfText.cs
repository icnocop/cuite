using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a text control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfText : WpfControl<CUITControls.WpfText>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfText"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfText(By searchConfiguration = null)
            : this(new CUITControls.WpfText(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfText"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfText(CUITControls.WpfText sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text for this text control.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }
    }
}