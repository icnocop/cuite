using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a progress bar control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlProgressBar : HtmlControl<CUITControls.HtmlProgressBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlProgressBar"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlProgressBar(By searchConfiguration = null)
            : this(new CUITControls.HtmlProgressBar(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlProgressBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlProgressBar(CUITControls.HtmlProgressBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the maximum position enabled on the progress bar.
        /// </summary>
        public float Max
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Max;
            }
        }

        /// <summary>
        /// Gets the value of the progress bar as a float.
        /// </summary>
        public float Value
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Value;
            }
        }
    }
}