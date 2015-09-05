#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightText.
    /// </summary>
    public class SilverlightText : SilverlightControl<CUITControls.SilverlightText>
    {
        public SilverlightText(By searchConfiguration = null)
            : this(new CUITControls.SilverlightText(), searchConfiguration)
        {
        }

        public SilverlightText(CUITControls.SilverlightText sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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