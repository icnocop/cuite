#if SILVERLIGHT_SUPPORT
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightRadioButton.
    /// </summary>
    public class SilverlightRadioButton : SilverlightControl<CUITControls.SilverlightRadioButton>
    {
        public SilverlightRadioButton()
        {
        }

        public SilverlightRadioButton(string searchParameters)
            : base(searchParameters)
        {
        }

        public void Select()
        {
            SourceControl.WaitForControlReady();
            SourceControl.Selected = true;
        }

        public bool IsSelected
        {
            get
            {
                SourceControl.WaitForControlReady();
                return SourceControl.Selected;
            }
        }
    }
}
#endif