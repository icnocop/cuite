using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePageWithInvalidControlSearchProperties : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "Google";
        public HtmlDiv controlWithInvalidSearchProperties = new HtmlDiv(By.SearchProperties("blanblah=res"));
    }
}
