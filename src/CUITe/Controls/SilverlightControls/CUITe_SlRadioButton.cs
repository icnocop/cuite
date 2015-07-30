using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    /// <summary>
    /// CUITe wrapper for SilverlightRadioButton.
    /// </summary>
    public class CUITe_SlRadioButton : CUITe_SlControl<SilverlightRadioButton>
    {
        public CUITe_SlRadioButton() : base() { }
        public CUITe_SlRadioButton(string searchParameters) : base(searchParameters) { }

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
