#if SILVERLIGHT_SUPPORT
using CUITe.SearchConfigurations;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightButton.
    /// </summary>
    public class SilverlightButton : SilverlightControl<CUITControls.SilverlightButton>
    {
        public SilverlightButton(By searchConfiguration = null)
            : this(new CUITControls.SilverlightButton(), searchConfiguration)
        {
        }

        public SilverlightButton(CUITControls.SilverlightButton sourceControl, By searchConfiguration = null)
            : base(sourceControl, searchConfiguration)
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