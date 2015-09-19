using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a table cell for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlCell : HtmlControl<CUITControls.HtmlCell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlCell"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlCell(By searchConfiguration = null)
            : this(new CUITControls.HtmlCell(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlCell"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlCell(CUITControls.HtmlCell sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}