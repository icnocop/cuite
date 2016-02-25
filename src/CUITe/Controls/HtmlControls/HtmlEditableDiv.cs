using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an editable Div control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlEditableDiv : HtmlControl<CUITControls.HtmlEditableDiv>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEditableDiv"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlEditableDiv(By searchConfiguration = null)
            : this(new CUITControls.HtmlEditableDiv(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEditableDiv"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlEditableDiv(CUITControls.HtmlEditableDiv sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the contents of the control.
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
        /// Gets a value that indicates whether the control is read-only.
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