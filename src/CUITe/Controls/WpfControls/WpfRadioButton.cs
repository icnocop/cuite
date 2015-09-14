using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a button control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfRadioButton : WpfControl<CUITControls.WpfRadioButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfRadioButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfRadioButton(By searchConfiguration = null)
            : this(new CUITControls.WpfRadioButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfRadioButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfRadioButton(CUITControls.WpfRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the group to which this radio button control belongs.
        /// </summary>
        public WpfGroup Group
        {
            get { return new WpfGroup((CUITControls.WpfGroup)SourceControl.Group); }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this radio button is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
            set { SourceControl.Selected = value; }
        }
    }
}