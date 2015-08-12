using System.Threading;
using CUITe.Controls.HtmlControls;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.TelerikControls
{
    public class ComboBox : HtmlControl<CUITControls.HtmlDiv>
    {
        private string id;
        private BrowserWindowUnderTest _window;
        
        public ComboBox() : base() { }

        public ComboBox(string searchParameters)
            : base(searchParameters)
        {
            this.id = searchParameters.Trim().Split('=', '~')[1];
        }

        internal void SetWindow(BrowserWindowUnderTest window) 
        {
            this._window = window;
        }

        public void SelectItemByText(string sText, int milliseconds)
        {
            this._window.RunScript("var obj = window.$find('" + id + "');obj.toggleDropDown();");
            Thread.Sleep(milliseconds);
            this._window.RunScript("var obj = window.$find('" + id + "');obj.findItemByText('" + sText + "').select();obj.hideDropDown();");
        }
    }
}
