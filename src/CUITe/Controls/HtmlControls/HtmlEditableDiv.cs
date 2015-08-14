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
            SourceControl.WaitForControlReady();
            SourceControl.Text = sText;
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