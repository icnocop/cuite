#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightRadioButton.
    /// </summary>
    public class SilverlightRadioButton : SilverlightControl<CUITControls.SilverlightRadioButton>
    {
        public SilverlightRadioButton(string searchProperties = null)
            : this(new CUITControls.SilverlightRadioButton(), searchProperties)
        {
        }

        public SilverlightRadioButton(CUITControls.SilverlightRadioButton sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public void Select()
        {
            WaitForControlReady();
            SourceControl.Selected = true;
        }

        public bool IsSelected
        {
            get
            {
                WaitForControlReady();
                return SourceControl.Selected;
            }
        }
    }
}
#endif