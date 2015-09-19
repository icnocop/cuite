using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Represents a radio button control to test the user interface (UI) of Windows Forms.
    /// </summary>
    public class WinRadioButton : WinControl<CUITControls.WinRadioButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WinRadioButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinRadioButton(By searchConfiguration = null)
            : this(new CUITControls.WinRadioButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinRadioButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public WinRadioButton(CUITControls.WinRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the control that contains this radio button control.
        /// </summary>
        public WinGroup Group
        {
            get { return new WinGroup((CUITControls.WinGroup)SourceControl.Group); }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether this radio button control is selected.
        /// </summary>
        public bool Selected
        {
            get { return SourceControl.Selected; }
            set { SourceControl.Selected = value; }
        }
    }
}