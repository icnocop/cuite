using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a check box for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlHeaderCell : HtmlControl<CUITControls.HtmlHeaderCell>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHeaderCell"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlHeaderCell(By searchConfiguration = null)
            : this(new CUITControls.HtmlHeaderCell(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHeaderCell"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlHeaderCell(CUITControls.HtmlHeaderCell sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}