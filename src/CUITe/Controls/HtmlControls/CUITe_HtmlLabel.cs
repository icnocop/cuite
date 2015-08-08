using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlLabel : CUITe_HtmlControl<HtmlLabel>
    {
        public CUITe_HtmlLabel() : base() { }
        public CUITe_HtmlLabel(string searchParameters) : base(searchParameters) { }

        /// <summary>
        /// Gets the name of the control that is associated with this label.
        /// </summary>
        /// <value>
        /// The name of the control that is associated with this label.
        /// </value>
        public string LabelFor
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.LabelFor;
            }
        }
    }
}
