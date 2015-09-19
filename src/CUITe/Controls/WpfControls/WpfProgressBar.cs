using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a progress bar control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfProgressBar : WpfControl<CUITControls.WpfProgressBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfProgressBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfProgressBar(By searchConfiguration = null)
            : this(new CUITControls.WpfProgressBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfProgressBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfProgressBar(CUITControls.WpfProgressBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the maximum numeric value for this progress bar control.
        /// </summary>
        public double MaximumValue
        {
            get { return SourceControl.MaximumValue; }
        }

        /// <summary>
        /// Gets the minimum numeric value for this progress bar control.
        /// </summary>
        public double MinimumValue
        {
            get { return SourceControl.MinimumValue; }
        }

        /// <summary>
        /// Gets the current numeric position for this progress bar control.
        /// </summary>
        public double Position
        {
            get { return SourceControl.Position; }
        }
    }
}