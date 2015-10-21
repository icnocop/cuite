using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a list item control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlCustomListItem : HtmlCustom
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlCustomListItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlCustomListItem(By searchConfiguration = null)
            : this(new CUITControls.HtmlCustom(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlCustomListItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlCustomListItem(CUITControls.HtmlCustom sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}