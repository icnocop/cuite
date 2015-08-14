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
            _control.WaitForControlReady();
            _control.Selected = true;
        }

        public bool IsSelected
        {
            get
            {
                _control.WaitForControlReady();
                return _control.Selected;
            }
        }
    }
}
#endif