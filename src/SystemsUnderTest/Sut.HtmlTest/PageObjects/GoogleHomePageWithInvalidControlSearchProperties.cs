using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    public class GoogleHomePageWithInvalidControlSearchProperties : Page
    {
        public HtmlDiv ControlWithInvalidSearchProperties
        {
            get { return Find<HtmlDiv>(By.SearchProperties("blanblah=res")); }
        }
    }
}