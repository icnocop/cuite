using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a check box control to test the user interface (UI) of a Silverlight
    /// application.
    /// </summary>
    public class SilverlightCheckBox : SilverlightControl<CUITControls.SilverlightCheckBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightCheckBox" /> class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightCheckBox(UITestControl parent, By searchConfiguration = null)
            : this(new CUITControls.SilverlightCheckBox(parent), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightCheckBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightCheckBox(CUITControls.SilverlightCheckBox sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Checks the check box.
        /// </summary>
        public void Check()
        {
            if (!Checked)
            {
                Checked = true;
            }
        }

        /// <summary>
        /// Un-checks the check box.
        /// </summary>
        public void UnCheck()
        {
            if (Checked)
            {
                Checked = false;
            }
        }

        /// <summary>
        /// Gets or sets the checked state.
        /// </summary>
        public bool Checked
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Checked;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.Checked = value;
            }
        }
    }
}
