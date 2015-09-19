using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents an expander control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfExpander : WpfControl<CUITControls.WpfExpander>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfExpander"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfExpander(By searchConfiguration = null)
            : this(new CUITControls.WpfExpander(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfExpander"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfExpander(CUITControls.WpfExpander sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this expander control is expanded.
        /// </summary>
        public bool Expanded
        {
            get { return SourceControl.Expanded; }
        }

        /// <summary>
        /// Gets the contents of the header part of this expander control.
        /// </summary>
        public string Header
        {
            get { return SourceControl.Header; }
        }
    }
}