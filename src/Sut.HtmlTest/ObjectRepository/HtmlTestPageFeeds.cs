using CUITe.Controls.HtmlControls;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.ObjectRepository
{
    public class HtmlTestPageFeeds : BrowserWindowUnderTest
    {
        public HtmlTestPageFeeds()
            : base("test")
        {
        }

        public HtmlCustom cusDataFeedTabsNav2
        {
            get { return divFeedTabs.Find<HtmlCustom>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        public HtmlUnorderedList cusDataFeedTabsNav
        {
            get { return Find<HtmlUnorderedList>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        public HtmlDiv divFeedTabs
        {
            get { return Find<HtmlDiv>(By.Id("feed_tabs")); }
        }

        public HtmlUnorderedList cusdatafeedtabsnav1
        {
            get { return divFeedTabs.Find<HtmlUnorderedList>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }
    }
}