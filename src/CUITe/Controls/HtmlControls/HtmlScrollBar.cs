using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a scroll bar control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlScrollBar : HtmlControl<CUITControls.HtmlScrollBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlScrollBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlScrollBar(By searchConfiguration = null)
            : this(new CUITControls.HtmlScrollBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlScrollBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlScrollBar(CUITControls.HtmlScrollBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the orientation direction for this scroll bar.
        /// </summary>
        public string Orientation
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Orientation;
            }
        }
    }
}