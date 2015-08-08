using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlRadioButton : CUITe_HtmlControl<HtmlRadioButton>
    {
        public CUITe_HtmlRadioButton() : base() { }
        public CUITe_HtmlRadioButton(string searchParameters) : base(searchParameters) { }

        public void Select()
        {
            this._control.WaitForControlReady();
            this._control.Selected = true;
        }

        public void Select2()
        {
            this._control.WaitForControlReady();
            string sOnClick = (string)this._control.GetProperty("onclick");
            string sId = this._control.Id;
            if (sId == null || sId == "")
            {
                throw new CUITe_GenericException("Select2(): No ID found for the RadioButton!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public bool IsSelected
        {
            get {
                this._control.WaitForControlReady();
                return this._control.Selected; 
            }
        }
    }
}
