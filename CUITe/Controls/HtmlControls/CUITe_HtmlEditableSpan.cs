using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlEditableSpan : CUITe_HtmlControl<HtmlEditableSpan>
    {
        public CUITe_HtmlEditableSpan() : base() { }
        public CUITe_HtmlEditableSpan(string searchParameters) : base(searchParameters) { }

        public void SetText(string sText)
        {
            this._control.WaitForControlReady();
            this._control.CopyPastedText = sText;
        }

        public string GetText()
        {
            this._control.WaitForControlReady();
            return this._control.Text; 
        }

        public bool ReadOnly
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ReadOnly;
            }
        }
    }
}
