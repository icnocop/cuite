using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlRadioButton : HtmlControl<CUITControls.HtmlRadioButton>
    {
        public HtmlRadioButton() : base() { }
        public HtmlRadioButton(string searchParameters) : base(searchParameters) { }

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
                throw new GenericException("Select2(): No ID found for the RadioButton!");
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
