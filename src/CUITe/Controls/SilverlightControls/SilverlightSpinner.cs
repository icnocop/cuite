﻿#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// Represents a spinner control to test the user interface (UI) of a Silverlight application.
    /// </summary>
    public class SilverlightSpinner : SilverlightControl<CUITControls.SilverlightControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightSpinner"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightSpinner(By searchConfiguration = null)
            : this(new CUITControls.SilverlightControl(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SilverlightSpinner"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public SilverlightSpinner(CUITControls.SilverlightControl sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
            AddSearchProperty(UITestControl.PropertyNames.ControlType, "Spinner");
        }

        /// <summary>
        /// Gets or sets the text displayed in the spinner control.
        /// </summary>
        public string Text
        {
            get
            {
                WaitForControlReady();
                return TextBox.Text;
            }
            set
            {
                WaitForControlReady();
                TextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets a value that indicates whether the spinner control is read-only.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                WaitForControlReady();
                return TextBox.ReadOnly;
            }
        }

        private SilverlightEdit TextBox
        {
            get { return Find<SilverlightEdit>(); }
        }
    }
}
#endif