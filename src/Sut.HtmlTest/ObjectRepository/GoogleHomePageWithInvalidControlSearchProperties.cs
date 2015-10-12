using CUITe.Controls.HtmlControls;
using CUITe.ObjectRepository;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.HtmlTest.ObjectRepository
{
    public class GoogleHomePageWithInvalidControlSearchProperties : Page
    {
        public GoogleHomePageWithInvalidControlSearchProperties(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        public HtmlDiv ControlWithInvalidSearchProperties
        {
            get { return Find<HtmlDiv>(By.SearchProperties("blanblah=res")); }
        }
    }
}