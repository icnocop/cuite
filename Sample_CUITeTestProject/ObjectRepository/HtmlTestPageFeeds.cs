using CUITe.Controls.HtmlControls;

namespace Sample_CUITeTestProject.ObjectRepository
{
    public class HtmlTestPageFeeds : CUITe_BrowserWindow
    {
        public HtmlTestPageFeeds()
            : base("test")
        {
        }

        public CUITe_HtmlCustom cusDataFeedTabsNav2
        {
            get
            {
                return this.divFeedTabs.Get<CUITe_HtmlCustom>("Class=dataFeedTab ui-tabs-nav");
            }
        }

        public CUITe_HtmlUnorderedList cusDataFeedTabsNav
        {
            get
            {
                return this.Get<CUITe_HtmlUnorderedList>("Class=dataFeedTab ui-tabs-nav;TagName=ul");
            }
        }

        public CUITe_HtmlDiv divFeedTabs
        {
            get
            {
                return this.Get<CUITe_HtmlDiv>("Id=feed_tabs");
            }
        }

        public CUITe_HtmlUnorderedList cusdatafeedtabsnav1
        {
            get
            {
                return (this.divFeedTabs.Get<CUITe_HtmlUnorderedList>("Class=dataFeedTab ui-tabs-nav;TagName=ul"));
            }
        }

        public CUITe_HtmlCustom cusDataFeedTabsNav3
        {
            get
            {
                return this.divFeedTabs.Get<CUITe_HtmlCustom>("Class=dataFeedTab ui-tabs-nav;TagName=ul");
            }
        }
    }
}
