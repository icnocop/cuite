using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePage : BrowserWindowUnderTest
    {
        public new string sWindowTitle = "Google";
        public HtmlEdit txtSearch = new HtmlEdit(By.SearchProperties("Id=lst-ib"));
    }
}
