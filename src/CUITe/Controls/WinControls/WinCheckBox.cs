using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a check box control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinCheckBox : WinControl<CUITControls.WinCheckBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinCheckBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCheckBox(By searchConfiguration = null)
            : this(new CUITControls.WinCheckBox(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinCheckBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinCheckBox(CUITControls.WinCheckBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the check box is checked.
        /// </summary>
        public bool Checked
        {
            get { return SourceControl.Checked; }
            set { SourceControl.Checked = value; }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the state of the check box is
        /// indeterminate.
        /// </summary>
        public bool Indeterminate
        {
            get { return SourceControl.Indeterminate; }
            set { SourceControl.Indeterminate = value; }
        }
    }
}