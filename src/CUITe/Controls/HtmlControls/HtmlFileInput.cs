using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlFileInput : HtmlControl<CUITControls.HtmlFileInput>
    {
        public HtmlFileInput() : base() { }
        public HtmlFileInput(string searchParameters) : base(searchParameters) { }

        public void SetFile(string sFilePath)
        {
            this._control.FileName = sFilePath;
        }
    }
}
