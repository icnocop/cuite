using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a span control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlSpan : HtmlControl<CUITControls.HtmlSpan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSpan"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlSpan(By searchConfiguration = null)
            : this(new CUITControls.HtmlSpan(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSpan"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlSpan(CUITControls.HtmlSpan sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}