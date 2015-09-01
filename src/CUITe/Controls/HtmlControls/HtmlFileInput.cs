using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlFileInput : HtmlControl<CUITControls.HtmlFileInput>
    {
        public HtmlFileInput(string searchProperties = null)
            : this(new CUITControls.HtmlFileInput(), searchProperties)
        {
        }

        public HtmlFileInput(CUITControls.HtmlFileInput sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public void SetFile(string sFilePath)
        {
            SourceControl.FileName = sFilePath;
        }
    }
}