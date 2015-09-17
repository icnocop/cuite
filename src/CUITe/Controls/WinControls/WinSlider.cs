using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a slider control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinSlider : WinControl<CUITControls.WinSlider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinSlider"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSlider(By searchConfiguration = null)
            : this(new CUITControls.WinSlider(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinSlider"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSlider(CUITControls.WinSlider sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the line size of this slider control.
        /// </summary>
        public double LineSize
        {
            get { return SourceControl.LineSize; }
        }

        /// <summary>
        /// Gets the maximum position of this slider control.
        /// </summary>
        public double MaximumPosition
        {
            get { return SourceControl.MaximumPosition; }
        }

        /// <summary>
        /// Gets the minimum position of this slider control.
        /// </summary>
        public double MinimumPosition
        {
            get { return SourceControl.MinimumPosition; }
        }

        /// <summary>
        /// Gets the page size for this slider control.
        /// </summary>
        public double PageSize
        {
            get { return SourceControl.PageSize; }
        }

        /// <summary>
        /// Gets or sets the current numeric position for this slider control.
        /// </summary>
        public double Position
        {
            get { return SourceControl.Position; }
            set { SourceControl.Position = value; }
        }

        /// <summary>
        /// Gets or sets a string version of the current numeric position for this slider control.
        /// </summary>
        public string PositionAsString
        {
            get { return SourceControl.PositionAsString; }
            set { SourceControl.PositionAsString = value; }
        }

        /// <summary>
        /// Gets the number of tick positions in this slider control.
        /// </summary>
        public double TickCount
        {
            get { return SourceControl.TickCount; }
        }

        /// <summary>
        /// Gets the current tick position for this slider control.
        /// </summary>
        public double TickPosition
        {
            get { return SourceControl.TickPosition; }
        }

        /// <summary>
        /// Gets the tick value of the current position for this slider.
        /// </summary>
        public double TickValue
        {
            get { return SourceControl.TickValue; }
        }
    }
}