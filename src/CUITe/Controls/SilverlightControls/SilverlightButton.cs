#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightButton.
    /// </summary>
    public class SilverlightButton : SilverlightControl<CUITControls.SilverlightButton>
    {
        public SilverlightButton(string searchProperties = null)
            : this(new CUITControls.SilverlightButton(), searchProperties)
        {
        }

        public SilverlightButton(CUITControls.SilverlightButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        /// <summary>
        /// Gets the text displayed on the Silverlight Button.
        /// </summary>
        public string DisplayText
        {
            get
            {
                WaitForControlReady();
                return SourceControl.DisplayText;
            }
        }
    }
}

#endif