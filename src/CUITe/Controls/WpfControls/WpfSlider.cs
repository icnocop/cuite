using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a slider control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfSlider : WpfControl<CUITControls.WpfSlider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfSlider"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfSlider(By searchConfiguration = null)
            : this(new CUITControls.WpfSlider(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfSlider"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfSlider(CUITControls.WpfSlider sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the numeric large change value for this slider control.
        /// </summary>
        public double LargeChange
        {
            get { return SourceControl.LargeChange; }
        }

        /// <summary>
        /// Gets the numeric value for the maximum position of this slider control.
        /// </summary>
        public double MaximumPosition
        {
            get { return SourceControl.MaximumPosition; }
        }

        /// <summary>
        /// Gets the numeric value for the maximum position of this slider control.
        /// </summary>
        public double MinimumPosition
        {
            get { return SourceControl.MinimumPosition; }
        }

        /// <summary>
        /// Gets the current numeric position for this slider control.
        /// </summary>
        public double Position
        {
            get { return SourceControl.Position; }
            set { SourceControl.Position = value; }
        }

        /// <summary>
        /// Gets the current position for this slider control as a string.
        /// </summary>
        public string PositionAsString
        {
            get { return SourceControl.PositionAsString; }
            set { SourceControl.PositionAsString = value; }
        }

        /// <summary>
        /// Gets the numeric small change value for this slider control.
        /// </summary>
        public double SmallChange
        {
            get { return SourceControl.SmallChange; }
        }
    }
}