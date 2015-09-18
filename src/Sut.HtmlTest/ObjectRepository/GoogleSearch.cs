using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleSearch : BrowserWindowUnderTest
    {
        public new string WindowTitle { get { return "coded ui test framework - Google Search"; } }
        public HtmlDiv divSearchResults = new HtmlDiv(By.Id("ires"));
    }
}
