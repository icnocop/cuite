#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a tree control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightTree : SilverlightControl<CUITControls.SilverlightTree>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTree"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTree(By searchConfiguration = null)
            : this(new CUITControls.SilverlightTree(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTree"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTree(CUITControls.SilverlightTree sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif