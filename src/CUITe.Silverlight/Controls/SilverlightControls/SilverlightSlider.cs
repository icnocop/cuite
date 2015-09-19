#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a slider control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightSlider : SilverlightControl<CUITControls.SilverlightSlider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightSlider"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightSlider(By searchConfiguration = null)
            : this(new CUITControls.SilverlightSlider(), searchConfiguration)
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
#endif