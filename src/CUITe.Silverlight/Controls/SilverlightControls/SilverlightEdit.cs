using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents an edit control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightEdit : SilverlightControl<CUITControls.SilverlightEdit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightEdit" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightEdit(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightEdit(parent), searchConfiguration)
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
        /// Gets a value that indicates whether the edit control is read-only.
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
