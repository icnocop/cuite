using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightLabel.
    /// </summary>
    public class CUITe_SlLabel : CUITe_SlControl<SilverlightLabel>
    {
        public CUITe_SlLabel() : base() { }
        public CUITe_SlLabel(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the text displayed on the label.
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
