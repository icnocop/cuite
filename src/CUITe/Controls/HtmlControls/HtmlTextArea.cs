using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlTextArea : HtmlControl<CUITControls.HtmlTextArea>
    {
        public HtmlTextArea(CUITControls.HtmlTextArea sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlTextArea(), searchProperties)
        {
        }

        public void SetText(string sText)
        {
            WaitForControlReady();
            SourceControl.Text = sText;
        }

        public string Text
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Text;
            }
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