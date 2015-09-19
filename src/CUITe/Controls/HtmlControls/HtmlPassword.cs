using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an HTML password control for testing the user interface (UI) of Web pages.
    /// </summary>
    public class HtmlPassword : HtmlEdit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlPassword"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlPassword(By searchConfiguration = null)
            : this(new CUITControls.HtmlEdit(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlPassword"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlPassword(CUITControls.HtmlEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(CUITControls.HtmlControl.PropertyNames.Type, "PASSWORD");
        }
    }
}