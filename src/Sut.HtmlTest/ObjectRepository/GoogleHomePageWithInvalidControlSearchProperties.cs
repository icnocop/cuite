using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePageWithInvalidControlSearchProperties : Page
    {
        public HtmlDiv ControlWithInvalidSearchProperties
        {
            get { return Find<HtmlDiv>(By.SearchProperties("blanblah=res")); }
        }
    }
}