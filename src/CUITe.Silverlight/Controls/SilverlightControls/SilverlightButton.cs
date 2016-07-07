using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a button control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightButton : SilverlightControl<CUITControls.SilverlightButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightButton" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightButton(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightButton(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightButton(CUITControls.SilverlightButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the text that is displayed on the button.
        /// </summary>
        public string DisplayText
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.DisplayText;
            }
        }
    }
}

