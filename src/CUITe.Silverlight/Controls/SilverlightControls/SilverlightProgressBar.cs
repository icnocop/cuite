using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a progress bar control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightProgressBar : SilverlightControl<CUITControls.SilverlightProgressBar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightProgressBar" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightProgressBar(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightProgressBar(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightProgressBar"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightProgressBar(CUITControls.SilverlightProgressBar sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
