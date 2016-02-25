using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a file input control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlFileInput : HtmlControl<CUITControls.HtmlFileInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlFileInput"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlFileInput(By searchConfiguration = null)
            : this(new CUITControls.HtmlFileInput(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlFileInput"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlFileInput(CUITControls.HtmlFileInput sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the file name in this control.
        /// </summary>
        public string FileName
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.FileName;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.FileName = value;
            }
        }
    }
}