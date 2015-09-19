#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a tab item control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightTabItem : SilverlightControl<CUITControls.SilverlightTabItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTabItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTabItem(By searchConfiguration = null)
            : this(new CUITControls.SilverlightTabItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightTabItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightTabItem(CUITControls.SilverlightTabItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif