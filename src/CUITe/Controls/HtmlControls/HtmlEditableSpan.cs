using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEditableSpan : HtmlControl<CUITControls.HtmlEditableSpan>
    {
        public HtmlEditableSpan()
        {
        }

        public HtmlEditableSpan(string searchParameters)
            : base(searchParameters)
        {
        }

        public void SetText(string sText)
        {
            SourceControl.WaitForControlReady();
            SourceControl.CopyPastedText = sText;
        }

        public string GetText()
        {
            SourceControl.WaitForControlReady();
            return SourceControl.Text;
        }

        public bool ReadOnly
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.ReadOnly;
            }
        }
    }
}