using CUITe.Controls.HtmlControls;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleSearch : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "coded ui test framework - Google Search";
        public HtmlDiv divSearchResults = new HtmlDiv("Id=ires");
    }
}
