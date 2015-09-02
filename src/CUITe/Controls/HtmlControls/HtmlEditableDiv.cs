using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEditableDiv : HtmlControl<CUITControls.HtmlEditableDiv>
    {
        public HtmlEditableDiv(By searchConfiguration = null)
            : this(new CUITControls.HtmlEditableDiv(), searchConfiguration)
        {
        }

        public HtmlEditableDiv(CUITControls.HtmlEditableDiv sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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