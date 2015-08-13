using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
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
                HtmlCustom ul = this.divFeedTabs.Get<HtmlCustom>("ul");
                ul.SetSearchProperties("Class=dataFeedTab ui-tabs-nav");
                return ul;
            }
        }

        public HtmlUnorderedList cusDataFeedTabsNav
        {
            get
            {
                return this.Get<HtmlUnorderedList>("Class=dataFeedTab ui-tabs-nav;TagName=ul");
            }
        }

        public HtmlDiv divFeedTabs
        {
            get
            {
                return this.Get<HtmlDiv>("Id=feed_tabs");
            }
        }

        public HtmlUnorderedList cusdatafeedtabsnav1
        {
            get
            {
                return this.divFeedTabs.Get<HtmlUnorderedList>("Class=dataFeedTab ui-tabs-nav;TagName=ul");
            }
        }
    }
}
