using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlLabel : HtmlControl<CUITControls.HtmlLabel>
    {
        public HtmlLabel()
        {
        }

        public HtmlLabel(string searchParameters)
            : base(searchParameters)
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
                SourceControl.WaitForControlReady();
                return SourceControl.LabelFor;
            }
        }
    }
}