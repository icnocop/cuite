using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an editable span control for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlEditableSpan : HtmlControl<CUITControls.HtmlEditableSpan>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEditableSpan"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlEditableSpan(By searchConfiguration = null)
            : this(new CUITControls.HtmlEditableSpan(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlEditableSpan"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlEditableSpan(CUITControls.HtmlEditableSpan sourceControl, By searchConfiguration = null)
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
                WaitForControlReady();
                return SourceControl.Text;
            }
            set
            {
                WaitForControlReady();
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
                WaitForControlReady();
                return SourceControl.ReadOnly;
            }
        }
    }
}