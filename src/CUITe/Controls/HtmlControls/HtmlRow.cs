using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a table row control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlRow : HtmlControl<CUITControls.HtmlRow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRow"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlRow(By searchConfiguration = null)
            : this(new CUITControls.HtmlRow(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRow"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlRow(CUITControls.HtmlRow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}