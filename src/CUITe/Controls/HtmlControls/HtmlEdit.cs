using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an HTML edit control for testing the user interface (UI) of Web pages.
    /// </summary>
    public class HtmlEdit : HtmlControl<CUITControls.HtmlEdit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEdit"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlEdit(By searchConfiguration = null)
            : this(new CUITControls.HtmlEdit(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEdit"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlEdit(CUITControls.HtmlEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the contents of this edit control.
        /// </summary>
        public string Text
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Text;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.Text = value;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether this edit control is read-only.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.ReadOnly;
            }
        }
    }
}