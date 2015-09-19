using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an HTML document control to test the user interface (UI) of Web pages.
    /// </summary>
    public class HtmlDocument : HtmlControl<CUITControls.HtmlDocument>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDocument"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlDocument(By searchConfiguration = null)
            : this(new CUITControls.HtmlDocument(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDocument"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlDocument(CUITControls.HtmlDocument sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}