using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a button control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfScrollBar : WpfControl<CUITControls.WpfScrollBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfScrollBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfScrollBar(By searchConfiguration = null)
            : this(new CUITControls.WpfScrollBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfScrollBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfScrollBar(CUITControls.WpfScrollBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the numeric value for the maximum position of this scroll bar control.
        /// </summary>
        public double MaximumPosition
        {
            get { return SourceControl.MaximumPosition; }
        }

        /// <summary>
        /// Gets the numeric value for the minimum position of this scroll bar control.
        /// </summary>
        public double MinimumPosition
        {
            get { return SourceControl.MinimumPosition; }
        }

        /// <summary>
        /// Gets the current numeric position for this scroll bar control.
        /// </summary>
        public double Position
        {
            get { return SourceControl.Position; }
        }
    }
}