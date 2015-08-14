using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlTextArea : HtmlControl<CUITControls.HtmlTextArea>
    {
        public HtmlTextArea()
        {
        }

        public HtmlTextArea(string searchParameters)
            : base(searchParameters)
        {
        }

        public void SetText(string sText)
        {
            SourceControl.WaitForControlReady();
            SourceControl.Text = sText;
        }

        public string Text
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Text;
            }
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