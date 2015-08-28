using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlFileInput : HtmlControl<CUITControls.HtmlFileInput>
    {
        public HtmlFileInput(CUITControls.HtmlFileInput sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.HtmlFileInput(), searchProperties)
        {
        }

        public void SetFile(string sFilePath)
        {
            SourceControl.FileName = sFilePath;
        }
    }
}