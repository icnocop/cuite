#if SILVERLIGHT_SUPPORT
using Microsoft.VisualStudio.TestTools.UITesting;

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
        public SilverlightPassword()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightPassword"/> class.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        public SilverlightPassword(string searchParameters)
            : base(searchParameters)
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
                SourceControl.WaitForControlReady();
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