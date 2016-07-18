using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Silverlight child window
    /// </summary>
    public class SilverlightChildWindow : SilverlightControl<CUITControls.SilverlightChildWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightChildWindow" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightChildWindow(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightChildWindow(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightChildWindow"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightChildWindow(CUITControls.SilverlightChildWindow sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
