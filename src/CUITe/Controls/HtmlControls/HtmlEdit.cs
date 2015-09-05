using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlEdit : HtmlControl<CUITControls.HtmlEdit>
    {
        public HtmlEdit(By searchConfiguration = null)
            : this(new CUITControls.HtmlEdit(), searchConfiguration)
        {
        }

        public HtmlEdit(CUITControls.HtmlEdit sourceControl, By searchConfiguration = null)
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