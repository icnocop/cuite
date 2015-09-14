using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Represents a check box control to test the user interface (UI) of Windows Presentation
    /// Foundation (WPF) applications.
    /// </summary>
    public class WpfCheckBox : WpfControl<CUITControls.WpfCheckBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCheckBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCheckBox(By searchConfiguration = null)
            : this(new CUITControls.WpfCheckBox(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WpfCheckBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WpfCheckBox(CUITControls.WpfCheckBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this check box is checked.
        /// </summary>
        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the value of this check box is indeterminate.
        /// </summary>
        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }
    }
}