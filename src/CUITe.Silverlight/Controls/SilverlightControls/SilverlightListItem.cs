using Microsoft.VisualStudio.TestTools.UITesting;
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
        /// Initializes a new instance of the <see cref="SilverlightListItem" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightListItem(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightListItem(parent), searchConfiguration)
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
