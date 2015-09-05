using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlFileInput : HtmlControl<CUITControls.HtmlFileInput>
    {
        public HtmlFileInput(By searchConfiguration = null)
            : this(new CUITControls.HtmlFileInput(), searchConfiguration)
        {
        }

        public HtmlFileInput(CUITControls.HtmlFileInput sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        public void SetFile(string sFilePath)
        {
            SourceControl.FileName = sFilePath;
        }
    }
}