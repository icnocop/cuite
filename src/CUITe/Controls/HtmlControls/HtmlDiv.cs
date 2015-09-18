using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a Div control to test the user interface (UI) of Web pages.
    /// </summary>
    public class HtmlDiv : HtmlControl<CUITControls.HtmlDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDiv"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlDiv(By searchConfiguration = null)
            : this(new CUITControls.HtmlDiv(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDiv"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlDiv(CUITControls.HtmlDiv sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}