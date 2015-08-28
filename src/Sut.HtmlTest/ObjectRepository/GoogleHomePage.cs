using CUITe.Controls.HtmlControls;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePage : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "Google";
        public HtmlEdit txtSearch = new HtmlEdit(searchProperties: "Id=lst-ib");
    }
}
