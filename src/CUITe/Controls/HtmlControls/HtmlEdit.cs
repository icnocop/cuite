using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEdit : HtmlControl<CUITControls.HtmlEdit>
    {
        public HtmlEdit(CUITControls.HtmlEdit sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlEdit(), searchProperties)
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