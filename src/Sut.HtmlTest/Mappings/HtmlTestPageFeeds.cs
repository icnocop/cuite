using CUITe.Controls.HtmlControls;
using CUITe.Mappings;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace Sut.HtmlTest.Mappings
{
    public class HtmlTestPageFeeds : Page
    {
        public HtmlTestPageFeeds(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        public HtmlUnorderedList CustomDataFeedTabsNav
        {
            get { return Find<HtmlUnorderedList>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        public HtmlUnorderedList CustomDataFeedTabsNav1
        {
            get { return DivFeedTabs.Find<HtmlUnorderedList>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        public HtmlCustom CustomDataFeedTabsNav2
        {
            get { return DivFeedTabs.Find<HtmlCustom>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        public HtmlDiv DivFeedTabs
        {
            get { return Find<HtmlDiv>(By.Id("feed_tabs")); }
        }
    }
}