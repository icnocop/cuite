using CUITe.Controls.HtmlControls;

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
            get
            {
                return divFeedTabs.Get<HtmlCustom>("TagName=ul;Class=dataFeedTab ui-tabs-nav");
            }
        }

        public HtmlUnorderedList cusDataFeedTabsNav
        {
            get
            {
                return Get<HtmlUnorderedList>("Class=dataFeedTab ui-tabs-nav;TagName=ul");
            }
        }

        public HtmlDiv divFeedTabs
        {
            get
            {
                return Get<HtmlDiv>("Id=feed_tabs");
            }
        }

        public HtmlUnorderedList cusdatafeedtabsnav1
        {
            get
            {
                return divFeedTabs.Get<HtmlUnorderedList>("Class=dataFeedTab ui-tabs-nav;TagName=ul");
            }
        }
    }
}
