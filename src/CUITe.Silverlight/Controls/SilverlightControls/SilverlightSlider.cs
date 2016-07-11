using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a slider control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightSlider : SilverlightControl<CUITControls.SilverlightSlider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightSlider" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightSlider(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightSlider(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightSlider"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightSlider(CUITControls.SilverlightSlider sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
