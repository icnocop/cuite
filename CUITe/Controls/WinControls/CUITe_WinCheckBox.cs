using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinCheckBox
    /// </summary>
    public class CUITe_WinCheckBox : CUITe_WinControl<WinCheckBox>
    {
        public CUITe_WinCheckBox() : base() { }
        public CUITe_WinCheckBox(string searchParameters) : base(searchParameters) { }

        public bool Checked { 
            get { return this._control.Checked; } 
            set { this._control.Checked = value; }
        }

        public bool Indeterminate
        {
            get { return this._control.Indeterminate; }
            set { this._control.Indeterminate = value; }
        }

    }
}
