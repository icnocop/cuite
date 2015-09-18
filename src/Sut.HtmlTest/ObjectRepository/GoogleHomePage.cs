using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePage : BrowserWindowUnderTest
    {
        public HtmlEdit txtSearch = new HtmlEdit(By.Id("lst-ib"));
    }
}
