#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightText.
    /// </summary>
    public class SilverlightText : SilverlightControl<CUIT.SilverlightText>
    {
        public SilverlightText() : base() { }
        public SilverlightText(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the text displayed on the SilverlightText block.
        /// </summary>
        public string Text
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Text;
            }
        }
    }
}
#endif