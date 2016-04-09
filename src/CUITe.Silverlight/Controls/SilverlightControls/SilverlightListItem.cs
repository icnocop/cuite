#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    using CUITe.SearchConfigurations;

    /// <summary>
    /// Silverlight list item
    /// </summary>
    public class SilverlightListItem : SilverlightControl<CUITControls.SilverlightListItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightListItem"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightListItem(By searchConfiguration = null)
            : this(new CUITControls.SilverlightListItem(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightListItem"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightListItem(CUITControls.SilverlightListItem sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
#endif