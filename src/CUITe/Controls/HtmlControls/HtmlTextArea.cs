using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a text area control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlTextArea : HtmlControl<CUITControls.HtmlTextArea>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTextArea"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlTextArea(By searchConfiguration = null)
            : this(new CUITControls.HtmlTextArea(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlTextArea"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlTextArea(CUITControls.HtmlTextArea sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the contents of this text area control.
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
        /// Gets a value that indicates whether this text area is read-only.
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