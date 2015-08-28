using Microsoft.VisualStudio.TestTools.UITesting;
#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit where IsPassword=true.
    /// </summary>
    public class SilverlightPassword : SilverlightEdit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightPassword"/> class.
        /// </summary>
        /// <param name="searchProperties">The search parameters.</param>
        public SilverlightPassword(CUITControls.SilverlightEdit sourceControl = null, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        /// <summary>
        /// Gets or sets the password text
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

        /// <summary>
        /// Sets the password text.
        /// </summary>
        /// <param name="password">The password.</param>
        public new void SetText(string password)
        {
            Text = password;
        }
    }
}
#endif