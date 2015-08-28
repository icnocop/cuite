#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightText.
    /// </summary>
    public class SilverlightText : SilverlightControl<CUITControls.SilverlightText>
    {
        public SilverlightText(CUITControls.SilverlightText sourceControl = null, string searchProperties = null)
            : base(sourceControl ?? new CUITControls.SilverlightText(), searchProperties)
        {
        }

        /// <summary>
        /// Gets the text displayed on the SilverlightText block.
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