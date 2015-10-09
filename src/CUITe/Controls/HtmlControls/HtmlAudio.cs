using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a audio control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlAudio : HtmlMedia
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlAudio"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlAudio(By searchConfiguration = null)
            : this(new CUITControls.HtmlAudio(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlAudio"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlAudio(CUITControls.HtmlAudio sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}