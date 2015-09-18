using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleSearch : BrowserWindowUnderTest
    {
        public HtmlDiv divSearchResults = new HtmlDiv(By.Id("ires"));
    }
}
