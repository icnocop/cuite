#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents an image control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightImage : SilverlightControl<CUITControls.SilverlightImage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightImage"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightImage(By searchConfiguration = null)
            : this(new CUITControls.SilverlightImage(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightImage"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightImage(CUITControls.SilverlightImage sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif