using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlTextArea : HtmlControl<CUITControls.HtmlTextArea>
    {
        public HtmlTextArea(By searchConfiguration = null)
            : this(new CUITControls.HtmlTextArea(), searchConfiguration)
        {
        }

        public HtmlTextArea(CUITControls.HtmlTextArea sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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