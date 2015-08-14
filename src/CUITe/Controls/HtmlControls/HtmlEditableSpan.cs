using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEditableSpan : HtmlControl<CUITControls.HtmlEditableSpan>
    {
        public HtmlEditableSpan() : base() { }
        public HtmlEditableSpan(string searchParameters) : base(searchParameters) { }

        public void SetText(string sText)
        {
            _control.WaitForControlReady();
            _control.CopyPastedText = sText;
        }

        public string GetText()
        {
            _control.WaitForControlReady();
            return _control.Text; 
        }

        public bool ReadOnly
        {
            get
            {
                _control.WaitForControlReady();
                return _control.ReadOnly;
            }
        }
    }
}
