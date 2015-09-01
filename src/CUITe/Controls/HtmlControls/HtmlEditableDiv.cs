using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEditableDiv : HtmlControl<CUITControls.HtmlEditableDiv>
    {
        public HtmlEditableDiv(string searchProperties = null)
            : this(new CUITControls.HtmlEditableDiv(), searchProperties)
        {
        }

        public HtmlEditableDiv(CUITControls.HtmlEditableDiv sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public void SetText(string sText)
        {
            WaitForControlReady();
            SourceControl.Text = sText;
        }

        public string GetText()
        {
            WaitForControlReady();
            return SourceControl.Text;
        }

        public bool ReadOnly
        {
            get
            {
                WaitForControlReady();
                return SourceControl.ReadOnly;
            }
        }
    }
}