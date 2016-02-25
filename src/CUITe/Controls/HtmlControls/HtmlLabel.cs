using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a label for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlLabel : HtmlControl<CUITControls.HtmlLabel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlLabel"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlLabel(By searchConfiguration = null)
            : this(new CUITControls.HtmlLabel(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlLabel"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlLabel(CUITControls.HtmlLabel sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the name of the control that is associated with this label.
        /// </summary>
        public string LabelFor
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.LabelFor;
            }
        }
    }
}