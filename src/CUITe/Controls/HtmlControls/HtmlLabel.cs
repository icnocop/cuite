using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlLabel : HtmlControl<CUITControls.HtmlLabel>
    {
        public HtmlLabel(string searchProperties = null)
            : this(new CUITControls.HtmlLabel(), searchProperties)
        {
        }

        public HtmlLabel(CUITControls.HtmlLabel sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
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