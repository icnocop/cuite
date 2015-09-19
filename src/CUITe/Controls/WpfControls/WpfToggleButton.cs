using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a toggle button control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfToggleButton : WpfControl<CUITControls.WpfToggleButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfToggleButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfToggleButton(By searchConfiguration = null)
            : this(new CUITControls.WpfToggleButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfToggleButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfToggleButton(CUITControls.WpfToggleButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the text that is displayed in this toggle button control.
        /// </summary>
        public string DisplayText
        {
            get { return SourceControl.DisplayText; }
        }

        /// <summary>
        /// Gets a value that indicates whether the value of this toggle button is indeterminate.
        /// </summary>
        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }

        /// <summary>
        /// Gets a value that indicates whether this toggle button control has been pressed.
        /// </summary>
        public bool Pressed
        {
            get { return SourceControl.Pressed; }
            set { SourceControl.Pressed = value; }
        }
    }
}