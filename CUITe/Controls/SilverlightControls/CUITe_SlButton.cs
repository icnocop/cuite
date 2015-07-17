using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightButton.
    /// </summary>
    public class CUITe_SlButton : CUITe_SlControl<SilverlightButton>
    {
        public CUITe_SlButton() : base() { }
        public CUITe_SlButton(string searchParameters) : base(searchParameters) { }

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
