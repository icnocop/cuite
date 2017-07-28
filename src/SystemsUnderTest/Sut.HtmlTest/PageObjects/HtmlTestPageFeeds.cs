using CUITe.Controls.HtmlControls;
using CUITe.PageObjects;
using CUITe.SearchConfigurations;

namespace Sut.HtmlTest.PageObjects
{
    /// <summary>
    /// HTML Test Page Feeds
    /// </summary>
    /// <seealso cref="CUITe.PageObjects.Page" />
    public class HtmlTestPageFeeds : Page
    {
        /// <summary>
        /// Gets the custom data feed tabs nav.
        /// </summary>
        /// <value>
        /// The custom data feed tabs nav.
        /// </value>
        public HtmlUnorderedList CustomDataFeedTabsNav
        {
            get { return Find<HtmlUnorderedList>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        /// <summary>
        /// Gets the custom data feed tabs nav1.
        /// </summary>
        /// <value>
        /// The custom data feed tabs nav1.
        /// </value>
        public HtmlUnorderedList CustomDataFeedTabsNav1
        {
            get { return DivFeedTabs.Find<HtmlUnorderedList>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        /// <summary>
        /// Gets the custom data feed tabs nav2.
        /// </summary>
        /// <value>
        /// The custom data feed tabs nav2.
        /// </value>
        public HtmlCustom CustomDataFeedTabsNav2
        {
            get { return DivFeedTabs.Find<HtmlCustom>(By.TagName("ul").AndSearchProperties("Class=dataFeedTab ui-tabs-nav")); }
        }

        /// <summary>
        /// Gets the div feed tabs.
        /// </summary>
        /// <value>
        /// The div feed tabs.
        /// </value>
        public HtmlDiv DivFeedTabs
        {
            get { return Find<HtmlDiv>(By.Id("feed_tabs")); }
        }
    }
}