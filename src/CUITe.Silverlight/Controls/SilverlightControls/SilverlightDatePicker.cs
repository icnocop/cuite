using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a control for selecting a date in the user interface (UI) of a Silverlight
    /// application.
    /// </summary>
    public class SilverlightDatePicker : SilverlightControl<CUITControls.SilverlightDatePicker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightDatePicker" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightDatePicker(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightDatePicker(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightDatePicker"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightDatePicker(CUITControls.SilverlightDatePicker sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }
    }
}
