using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an image control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlImage : HtmlControl<CUITControls.HtmlImage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlImage"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlImage(By searchConfiguration = null)
            : this(new CUITControls.HtmlImage(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlImage"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlImage(CUITControls.HtmlImage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}