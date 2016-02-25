using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a area hyperlink control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlAreaHyperlink : HtmlControl<CUITControls.HtmlAreaHyperlink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlAreaHyperlink"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlAreaHyperlink(By searchConfiguration = null)
            : this(new CUITControls.HtmlAreaHyperlink(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlAreaHyperlink"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlAreaHyperlink(CUITControls.HtmlAreaHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the value of the AbsolutePath attribute of this area hyperlink control.
        /// </summary>
        public string AbsolutePath
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.AbsolutePath;
            }
        }

        /// <summary>
        /// Gets the alternate text for this area hyperlink control.
        /// </summary>
        public string Alt
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Alt;
            }
        }

        /// <summary>
        /// Gets the value of the href attribute of this area hyperlink control.
        /// </summary>
        public string Href
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Href;
            }
        }

        /// <summary>
        /// Gets the value of the target attribute of this area hyperlink control.
        /// </summary>
        public string Target
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Target;
            }
        }
    }
}