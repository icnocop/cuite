using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an IFrame control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlIFrame : HtmlControl<CUITControls.HtmlIFrame>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlIFrame"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlIFrame(By searchConfiguration = null)
            : this(new CUITControls.HtmlIFrame(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlIFrame"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlIFrame(CUITControls.HtmlIFrame sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}