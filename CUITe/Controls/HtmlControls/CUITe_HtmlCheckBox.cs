using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlCheckBox : CUITe_HtmlControl<HtmlCheckBox>
    {
        public CUITe_HtmlCheckBox() : base() { }        
        public CUITe_HtmlCheckBox(string searchParameters) : base(searchParameters) { }

        public void Check()
        {
            this._control.WaitForControlReady();
            if (!this._control.Checked)
            {
                this._control.Checked = true;
            }
        }

        public void Check2()
        {
            this._control.WaitForControlReady();
            string sOnClick = (string)this._control.GetProperty("onclick");
            string sId = this._control.Id;
            if (sId == null || sId == "")
            {
                throw new CUITe_GenericException("Check2(): No ID found for the checkbox!");
            }
            RunScript("document.getElementById('" + sId + "').checked=true;" + sOnClick);
        }

        public void UnCheck()
        {
            this._control.WaitForControlReady();
            if (this._control.Checked)
            {
                this._control.Checked = false;
            }
        }

        public bool Checked
        {
            get 
            {
                this._control.WaitForControlReady();
                return this._control.Checked; 
            }
        }
    }
}
