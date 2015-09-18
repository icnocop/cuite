using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePageWithInvalidControlSearchProperties : BrowserWindowUnderTest
    {
        public HtmlDiv controlWithInvalidSearchProperties = new HtmlDiv(By.SearchProperties("blanblah=res"));
    }
}
