using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents an option button control for testing the user interface (UI) Web applications.
    /// </summary>
    public class HtmlRadioButton : HtmlControl<CUITControls.HtmlRadioButton>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRadioButton"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlRadioButton(By searchConfiguration = null)
            : this(new CUITControls.HtmlRadioButton(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlRadioButton"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlRadioButton(CUITControls.HtmlRadioButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Selects the radio button.
        /// </summary>
        public void Select()
        {
            if (!Selected)
            {
                Selected = true;    
            }
        }

        /// <summary>
        /// Selects the radio button.
        /// </summary>
        public void Select2()
        {
            WaitForControlReadyIfNecessary();
            string sOnClick = (string)SourceControl.GetProperty("onclick");
            string sId = SourceControl.Id;
            if (sId == null || sId == "")
            {
                throw new GenericException("Select2(): No ID found for the RadioButton!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        /// <summary>
        /// Gets or set a value that indicates whether this option button is selected.
        /// </summary>
        public bool Selected
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Selected;
            }
            set
            {
                WaitForControlReadyIfNecessary();
                SourceControl.Selected = value;
            }
        }
    }
}