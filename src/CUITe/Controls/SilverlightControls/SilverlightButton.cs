#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightButton.
    /// </summary>
    public class SilverlightButton : SilverlightControl<CUIT.SilverlightButton>
    {
        public SilverlightButton() : base() { }
        public SilverlightButton(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the text displayed on the Silverlight Button.
        /// </summary>
        public string DisplayText
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.DisplayText;
            }
        }
    }
}
#endif