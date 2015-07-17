using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_BrowserDialog : CUITe_BrowserWindow
    {
        public CUITe_BrowserDialog()
        {
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = GetCurrentBrowser().DialogClassName;
            this.WindowTitles.Add(this.sWindowTitle);
        }

        //public new void RunScript(string sCode)
        //{
        //    HtmlDocument document = new HtmlDocument(this);
        //    mshtml.IHTMLBodyElement idoc = (mshtml.IHTMLBodyElement)document.NativeElement;
        //    idoc.parentWindow.execScript(sCode);
        //}
    }
}
