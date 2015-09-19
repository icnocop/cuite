using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a hyperlink control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlHyperlink : HtmlControl<CUITControls.HtmlHyperlink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHyperlink"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlHyperlink(By searchConfiguration = null)
            : this(new CUITControls.HtmlHyperlink(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHyperlink"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlHyperlink(CUITControls.HtmlHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}