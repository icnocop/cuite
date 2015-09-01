#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightLabel.
    /// </summary>
    public class SilverlightLabel : SilverlightControl<CUITControls.SilverlightLabel>
    {
        public SilverlightLabel(string searchProperties = null)
            : this(new CUITControls.SilverlightLabel(), searchProperties)
        {
        }

        public SilverlightLabel(CUITControls.SilverlightLabel sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        /// <summary>
        /// Gets the text displayed on the label.
        /// </summary>
        public string Text
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Text;
            }
        }
    }
}
#endif