using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEditableSpan : HtmlControl<CUITControls.HtmlEditableSpan>
    {
        public HtmlEditableSpan(By searchConfiguration = null)
            : this(new CUITControls.HtmlEditableSpan(), searchConfiguration)
        {
        }

        public HtmlEditableSpan(CUITControls.HtmlEditableSpan sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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