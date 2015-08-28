using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEditableSpan : HtmlControl<CUITControls.HtmlEditableSpan>
    {
        public HtmlEditableSpan(CUITControls.HtmlEditableSpan sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlEditableSpan(), searchProperties)
        {
        }

        public void SetText(string sText)
        {
            WaitForControlReady();
            SourceControl.CopyPastedText = sText;
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