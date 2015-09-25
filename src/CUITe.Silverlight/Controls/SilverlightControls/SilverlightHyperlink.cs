#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a Windows hyperlink control to test the user interface (UI) of a Silverlight
    /// application.
    /// </summary>
    public class SilverlightHyperlink : SilverlightControl<CUITControls.SilverlightHyperlink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightHyperlink"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightHyperlink(By searchConfiguration = null)
            : this(new CUITControls.SilverlightHyperlink(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightHyperlink"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightHyperlink(CUITControls.SilverlightHyperlink sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif