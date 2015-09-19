#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents an label control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightLabel : SilverlightControl<CUITControls.SilverlightLabel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightLabel"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightLabel(By searchConfiguration = null)
            : this(new CUITControls.SilverlightLabel(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightLabel"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightLabel(CUITControls.SilverlightLabel sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the text of the label.
        /// </summary>
        public string Text
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Text;
            }
        }
    }
}
#endif