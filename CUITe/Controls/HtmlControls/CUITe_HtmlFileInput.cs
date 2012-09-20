using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlFileInput : CUITe_HtmlControl<HtmlFileInput>
    {
        public CUITe_HtmlFileInput() : base() { }
        public CUITe_HtmlFileInput(string searchParameters) : base(searchParameters) { }

        public void SetFile(string sFilePath)
        {
            this._control.FileName = sFilePath;
        }
    }
}
