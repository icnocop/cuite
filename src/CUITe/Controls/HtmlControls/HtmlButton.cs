using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a button control to test the user interface (UI) of Web pages.
    /// </summary>
    public class HtmlButton : HtmlControl<CUITControls.HtmlButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlButton(By searchConfiguration = null)
            : this(new CUITControls.HtmlButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlButton(CUITControls.HtmlButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}