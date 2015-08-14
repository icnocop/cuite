using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls.HtmlControls
{
    public class BrowserDialogUnderTest : BrowserWindowUnderTest
    {
        public BrowserDialogUnderTest()
        {
            SearchProperties[PropertyNames.ClassName] = GetCurrentBrowser().DialogClassName;
            WindowTitles.Add(sWindowTitle);
        }

        //public new void RunScript(string sCode)
        //{
        //    HtmlDocument document = new HtmlDocument(this);
        //    mshtml.IHTMLBodyElement idoc = (mshtml.IHTMLBodyElement)document.NativeElement;
        //    idoc.parentWindow.execScript(sCode);
        //}
    }
}
