using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an input button for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlInputButton : HtmlControl<CUITControls.HtmlInputButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlInputButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlInputButton(By searchConfiguration = null)
            : this(new CUITControls.HtmlInputButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlInputButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlInputButton(CUITControls.HtmlInputButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the display text for this input button.
        /// </summary>
        public string DisplayText
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.DisplayText;
            }
        }
    }
}