using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a tree control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightTree : SilverlightControl<CUITControls.SilverlightTree>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTree" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTree(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightTree(parent), searchConfiguration)
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
