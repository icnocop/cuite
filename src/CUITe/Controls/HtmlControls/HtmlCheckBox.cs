using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a check box for Web page user interface (UI) testing.
    /// </summary>
    public class HtmlCheckBox : HtmlControl<CUITControls.HtmlCheckBox>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlCheckBox"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlCheckBox(By searchConfiguration = null)
            : this(new CUITControls.HtmlCheckBox(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlCheckBox"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlCheckBox(CUITControls.HtmlCheckBox sourceControl, By searchConfiguration = null)
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
        /// Checks the check box.
        /// </summary>
        public void Check2()
        {
            WaitForControlReadyIfNecessary();
            string sOnClick = (string)SourceControl.GetProperty("onclick");
            string sId = SourceControl.Id;
            if (sId == null || sId == "")
            {
                throw new GenericException("Check2(): No ID found for the checkbox!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
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
        /// Gets or sets a value that indicates whether the check box is checked.
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