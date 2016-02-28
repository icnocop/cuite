#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a radio button control to test the user interface (UI) of a Silverlight
    /// application.
    /// </summary>
    public class SilverlightRadioButton : SilverlightControl<CUITControls.SilverlightRadioButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightRadioButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightRadioButton(By searchConfiguration = null)
            : this(new CUITControls.SilverlightRadioButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightRadioButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightRadioButton(CUITControls.SilverlightRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the selected state of the <see cref="SilverlightRadioButton"/> control.
        /// </summary>
        public bool Selected
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Selected;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.Selected = value;
            }
        }
    }
}
#endif