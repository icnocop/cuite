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
        public SilverlightPassword(string searchProperties = null)
            : this(new CUITControls.SilverlightEdit(), searchProperties)
        {
        }

        public SilverlightPassword(CUITControls.SilverlightEdit sourceControl, string searchProperties = null)
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