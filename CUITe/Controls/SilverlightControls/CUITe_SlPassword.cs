using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightEdit where IsPassword=true.
    /// </summary>
    public class CUITe_SlPassword : CUITe_SlEdit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CUITe_SlPassword"/> class.
        /// </summary>
        public CUITe_SlPassword()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CUITe_SlPassword"/> class.
        /// </summary>
        /// <param name="searchParameters">The search parameters.</param>
        public CUITe_SlPassword(string searchParameters)
            : base(searchParameters)
        {
        }

        /// <summary>
        /// Gets or sets the password text
        /// </summary>
        public new string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                this._control.WaitForControlReady();
                this._control.Password = Playback.EncryptText(value);
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
