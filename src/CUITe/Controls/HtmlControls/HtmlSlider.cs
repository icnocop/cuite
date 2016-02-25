using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    /// <summary>
    /// Represents a slider control for web page user interface (UI) testing.
    /// </summary>
    public class HtmlSlider : HtmlControl<CUITControls.HtmlSlider>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSlider"/> class.
        /// </summary>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlSlider(By searchConfiguration = null)
            : this(new CUITControls.HtmlSlider(), searchConfiguration)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSlider"/> class.
        /// </summary>
        /// <param name="sourceControl">The source control.</param>
        /// <param name="searchConfiguration">The search configuration.</param>
        public HtmlSlider(CUITControls.HtmlSlider sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets whether the control is disabled.
        /// </summary>
        public bool Disabled
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Disabled;
            }
        }

        /// <summary>
        /// Gets the maximum position enabled on the slider.
        /// </summary>
        public string Max
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Max;
            }
        }

        /// <summary>
        /// Gets the minimum position enabled on the slider.
        /// </summary>
        public string Min
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Min;
            }
        }

        /// <summary>
        /// Gets whether the control is required.
        /// </summary>
        public bool Required
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Required;
            }
        }

        /// <summary>
        /// Gets the step value enabled on the slider.
        /// </summary>
        public string Step
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Step;
            }
        }

        /// <summary>
        /// Gets the value of the slider as a string.
        /// </summary>
        public string Value
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.Value;
            }
        }

        /// <summary>
        /// Gets the current value of the slider as a floating point number.
        /// </summary>
        public double ValueAsNumber
        {
            get
            {
                WaitForControlReadyIfNecessary();
                return SourceControl.ValueAsNumber;
            }
        }
    }
}