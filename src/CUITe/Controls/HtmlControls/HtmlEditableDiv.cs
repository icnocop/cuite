using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEditableDiv : HtmlControl<CUITControls.HtmlEditableDiv>
    {
        public HtmlEditableDiv()
        {
        }

        public HtmlEditableDiv(string searchParameters)
            : base(searchParameters)
        {
        }

        public void SetText(string sText)
        {
            _control.WaitForControlReady();
            _control.Text = sText;
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