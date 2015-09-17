using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a progress bar control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinProgressBar : WinControl<CUITControls.WinProgressBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinProgressBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinProgressBar(By searchConfiguration = null)
            : this(new CUITControls.WinProgressBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinProgressBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinProgressBar(CUITControls.WinProgressBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the maximum numeric value for this progress bar.
        /// </summary>
        public double MaximumValue
        {
            get { return SourceControl.MaximumValue; }
        }

        /// <summary>
        /// Gets the minimum numeric value for this progress bar.
        /// </summary>
        public double MinimumValue
        {
            get { return SourceControl.MinimumValue; }
        }

        /// <summary>
        /// Gets the numeric value of this progress bar.
        /// </summary>
        public double Value
        {
            get { return SourceControl.Value; }
        }
    }
}