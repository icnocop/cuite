using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a frame control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlFrame : HtmlControl<CUITControls.HtmlFrame>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlFrame"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlFrame(By searchConfiguration = null)
            : this(new CUITControls.HtmlFrame(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlFrame"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlFrame(CUITControls.HtmlFrame sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the absolute path for the contents of the frame control.
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
        /// Gets the URL for the page that appears in the frame.
        /// </summary>
        public string PageUrl
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.PageUrl;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether this frame control is scrollable.
        /// </summary>
        public bool Scrollable
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Scrollable;
            }
        }
    }
}