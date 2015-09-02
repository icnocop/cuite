using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

#if SILVERLIGHT_SUPPORT
namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit where IsPassword=true.
    /// </summary>
    public class SilverlightPassword : SilverlightEdit
    {
        public SilverlightPassword(By searchConfiguration = null)
            : this(new CUITControls.SilverlightEdit(), searchConfiguration)
        {
        }

        public SilverlightPassword(CUITControls.SilverlightEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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