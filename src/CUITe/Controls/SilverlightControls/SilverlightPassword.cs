#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a password control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightPassword : SilverlightEdit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightPassword"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightPassword(By searchConfiguration = null)
            : this(new CUITControls.SilverlightEdit(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightPassword"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightPassword(CUITControls.SilverlightEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the password text displayed in the edit control.
        /// </summary>
        public new string Text
        {
            get { return base.Text; }
            set
            {
                WaitForControlReady();
                SourceControl.Password = Playback.EncryptText(value);
            }
        }
    }
}
#endif