using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a scroll bar control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinScrollBar : WinControl<CUITControls.WinScrollBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinScrollBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinScrollBar(By searchConfiguration = null)
            : this(new CUITControls.WinScrollBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinScrollBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinScrollBar(CUITControls.WinScrollBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the maximum numeric setting for this scroll bar.
        /// </summary>
        public double MaximumPosition
        {
            get { return SourceControl.MaximumPosition; }
        }

        /// <summary>
        /// Gets the minimum numeric setting for this scroll bar.
        /// </summary>
        public double MinimumPosition
        {
            get { return SourceControl.MinimumPosition; }
        }

        /// <summary>
        /// Gets or sets the current numeric position for this scroll bar.
        /// </summary>
        public double Position
        {
            get { return SourceControl.Position; }
        }
    }
}