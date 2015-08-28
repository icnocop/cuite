using CUITe.Controls.HtmlControls;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePageWithInvalidControlSearchProperties : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "Google";
        public HtmlDiv controlWithInvalidSearchProperties = new HtmlDiv(searchProperties: "blanblah=res");
    }
}
