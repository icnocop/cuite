using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a spinner control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinSpinner : WinControl<CUITControls.WinSpinner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinSpinner"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSpinner(By searchConfiguration = null)
            : this(new CUITControls.WinSpinner(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinSpinner"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinSpinner(CUITControls.WinSpinner sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the maximum numeric value in this spinner control.
        /// </summary>
        public int MaximumValue
        {
            get { return SourceControl.MaximumValue; }
        }

        /// <summary>
        /// Gets the minimum numeric value in this spinner control.
        /// </summary>
        public int MinimumValue
        {
            get { return SourceControl.MinimumValue; }
        }
    }
}