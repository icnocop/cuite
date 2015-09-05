using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlLabel : HtmlControl<CUITControls.HtmlLabel>
    {
        public HtmlLabel(By searchConfiguration = null)
            : this(new CUITControls.HtmlLabel(), searchConfiguration)
        {
        }

        public HtmlLabel(CUITControls.HtmlLabel sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
        {
        }

        /// <summary>
        /// Gets the name of the control that is associated with this label.
        /// </summary>
        /// <value>
        /// The name of the control that is associated with this label.
        /// </value>
        public string LabelFor
        {
            get
            {
                WaitForControlReady();
                return SourceControl.LabelFor;
            }
        }
    }
}