#if SILVERLIGHT_SUPPORT
using CUIT = Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightRadioButton.
    /// </summary>
    public class SilverlightRadioButton : SilverlightControl<CUIT.SilverlightRadioButton>
    {
        public SilverlightRadioButton() : base() { }
        public SilverlightRadioButton(string searchParameters) : base(searchParameters) { }

        public void Select()
        {
            this._control.WaitForControlReady();
            this._control.Selected = true;
        }

        public bool IsSelected
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Selected;
            }
        }
    }
}
#endif