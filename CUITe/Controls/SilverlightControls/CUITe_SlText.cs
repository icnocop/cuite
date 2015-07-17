using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightText.
    /// </summary>
    public class CUITe_SlText : CUITe_SlControl<SilverlightText>
    {
        public CUITe_SlText() : base() { }
        public CUITe_SlText(string searchParameters) : base(searchParameters) { }

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
