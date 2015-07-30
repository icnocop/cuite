using System.Threading;
using CUITe.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.TelerikControls
{
    public class Telerik_ComboBox : CUITe_HtmlControl<HtmlDiv>
    {
        private string id;
        private CUITe_BrowserWindow _window;
        
        public Telerik_ComboBox() : base() { }

        public Telerik_ComboBox(string searchParameters)
            : base(searchParameters)
        {
            this.id = searchParameters.Trim().Split('=', '~')[1];
        }

        internal void SetWindow(CUITe_BrowserWindow window) 
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
