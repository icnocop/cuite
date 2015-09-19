#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents an edit control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightEdit : SilverlightControl<CUITControls.SilverlightEdit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightEdit"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightEdit(By searchConfiguration = null)
            : this(new CUITControls.SilverlightEdit(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightEdit"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightEdit(CUITControls.SilverlightEdit sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets or sets the text displayed in the edit control.
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
        /// Gets a value that indicates whether the edit control is read-only.
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
#endif